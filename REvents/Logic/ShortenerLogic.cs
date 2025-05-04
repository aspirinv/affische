using R.Tools.Extensions;
using REvents.Data.DataSource;
using REvents.Data.Entities;
using REvents.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.Logic
{
    public class ShortenerLogic
    {
        private readonly IShortenerData data;

        public ShortenerLogic(IShortenerData data)
        {
            this.data = data;
        }

        internal async Task<string> RedirectTo(string code, VisiterData visiterData)
        {
            var link = await data.Find(code);
            if (link == null)
                return "/";

            _ = data.RecordVisit(new ShortLinkVisit
            {
                VisitTime = DateTime.UtcNow,
                FromIP = visiterData.IP,
                UserAgent = visiterData.UserAgent,
                LinkId = link.Id
            });

            if (link.ValidTo > DateTime.Today)
                return link.Url;
            return "/";
        }
        
        private const string symbols = "abcdefghijklmnopqrstuvwxyz12345678901234567890";
        private static Random rnd = new Random();

        internal async Task<string> Save(ShortLinkHeader link, string userId)
        {
            if (link.Url.IsEmpty())
            {
                throw new Exception("Url can't be empty");
            }
            var code = "";
            do
            {
                code = new string(Enumerable.Range(0, 5).Select(i => symbols[rnd.Next(symbols.Length)]).ToArray());
            } while (await data.Find(code) != null);

            await data.Save(new ShortLink
            {
                Code = code,
                Title = link.Title.IfEmpty(code),
                Url = link.Url,
                UserId = userId,
                ValidTo = new DateTime(link.ValidTo.Ticks, DateTimeKind.Utc)
            });
            return code;
        }

        internal async Task<ICollection<ShortLinkInfo>> List(string userId)
        {
            var entities = await data.List(userId);
            var stats = await data.GetVisitsStats(entities.Select(e => e.Id));
            return entities.Select(e => new ShortLinkInfo
            {
                Id = e.Id,
                Title = e.Title,
                Url = e.Url,
                ValidTo = e.ValidTo,
                VisitsAmount = stats.FirstOrDefault(x => x.Item1 == e.Id).Item2,
                Code = e.Code
            }).ToArray();
        }
    }
}
