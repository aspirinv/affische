using Google.Cloud.Firestore;
using REvents.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.DataSource
{
    public interface IShortenerData
    {
        Task Save(ShortLink link);
        Task<ShortLink> Find(string code);
        Task RecordVisit(ShortLink link, ShortLinkVisit visit);
    }

    public class FirebaseShortenerData : FirebaseClient, IShortenerData
    {
        private static List<ShortLink> cache;
        private static object __synclock = new object();

        public async Task<ShortLink> Find(string code)
        {
            if (cache != null)
            {
                return cache.FirstOrDefault(l => l.Code == code);
            }
            var collection = GetCollection();
            var document = await collection.Where(Filter.EqualTo("code", code))
                .OrderByDescending("validTo")
                .Limit(1).StreamAsync().FirstOrDefaultAsync();
            ReloadCache(collection);
            return document?.ConvertTo<ShortLink>();
        }

        public Task RecordVisit(ShortLink link, ShortLinkVisit visit)
        {
            throw new NotImplementedException();
        }

        public async Task Save(ShortLink link)
        {
            var collection = GetCollection();
            if (link.Id == Guid.Empty)
                link.Id = Guid.NewGuid();
            await collection.AddAsync(link);
            cache = null;
            ReloadCache(collection);
        }

        private CollectionReference GetCollection()
        {
            var db = CreateDb();
            var collection = db.Collection("links");
            return collection;
        }

        private void ReloadCache(CollectionReference links)
        {
            lock(__synclock)
            {
                if (cache == null)
                {
                    links.StreamAsync().ToListAsync().AsTask()
                        .ContinueWith(t => cache = t.Result.Select(d => d.ConvertTo<ShortLink>()).ToList())
                        .Wait();
                }
            }
        }
    }
}
