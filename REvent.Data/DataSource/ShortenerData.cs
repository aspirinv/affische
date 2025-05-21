using Google.Cloud.Firestore;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Options;
using REvents.Data.Entities;

namespace REvents.Data.DataSource
{
    public interface IShortenerData
    {
        Task Save(ShortLink link);
        Task<ShortLink?> Find(string code);
        Task RecordVisit(ShortLinkVisit visit);
        Task<ICollection<ShortLink>> List(string userId);
        Task<ICollection<(string, int)>> GetVisitsStats(IEnumerable<string> linkIds);
    }

    public class FirebaseShortenerData : FirebaseClient, IShortenerData
    {
        private static List<ShortLink>? cache;
        private static object __synclock = new object();

        public FirebaseShortenerData(IOptions<FirebaseOptions> options) : base(options)
        {
        }

        public async Task<ShortLink?> Find(string code)
        {
            var collection = Links();
            var document = await collection
                .WhereEqualTo("Code", code)
                .OrderByDescending("ValidTo")
                .Limit(1)
                .GetSnapshotAsync();
            return document.FirstOrDefault()?.ConvertTo<ShortLink>();
        }

        public async Task RecordVisit(ShortLinkVisit visit)
        {
            await Visits().Document().CreateAsync(visit);
        }

        public async Task Save(ShortLink link)
        {
            var collection = Links();
            await collection.AddAsync(link);
            cache = null;
            ReloadCache(collection);
        }

        public async Task<ICollection<ShortLink>> List(string userId)
        {
            return await Links()
                .WhereEqualTo("UserId", userId)
                .StreamAsync()
                .Select(e=>e.ConvertTo<ShortLink>())
                .ToArrayAsync();
        }
        
        public async Task<ICollection<(string, int)>> GetVisitsStats(IEnumerable<string> linkIds)
        {
            var visits = await Visits()
                .WhereIn("LinkId", linkIds)
                .StreamAsync()
                .Select(e=>e.ConvertTo<ShortLinkVisit>())
                .ToArrayAsync();
            return visits.GroupBy(e=>e.LinkId)
                .Select(g=>(g.Key, g.Count()))
                .ToList();
        }

        private CollectionReference Links()
        {
            var db = CreateDb();
            var collection = db.Collection("links");
            return collection;
        }
        
        private CollectionReference Visits()
        {
            var db = CreateDb();
            var collection = db.Collection("visits");
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
