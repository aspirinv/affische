using REvents.DataSource;
using REvents.DTO;
using REvents.Entities;
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

            data.RecordVisit(new ShortLinkVisit
            {
                VisitTime = DateTime.UtcNow,
                FromIP = visiterData.IP,
                UserAgent = visiterData.UserAgent,
                LinkId = link.Id
            }).Start();

            if (link.ValidTo > DateTime.Today)
                return link.Url;
            return "/";
        }
        
        private const string symbols = "abcdefghijklmnopqrstuvwxyz12345678901234567890";
        private static Random rnd = new Random();

        internal async Task<string> Save(ShortLinkHeader link)
        {
            var code = "";
            do
            {
                code = new string(Enumerable.Range(0, 5).Select(i => symbols[rnd.Next(symbols.Length)]).ToArray());
            } while (await data.Find(code) != null);

            await data.Save(new ShortLink
            {
                Code = code,
                Title = link.Title,
                Url = link.Url,
                ValidTo = link.ValidTo
            });
            return code;
        }

        internal async Task<ICollection<ShortLink>> List()
        {
            return await data.List();
        }
    }
}
