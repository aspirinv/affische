using REvents.DataSource;
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

        internal async Task<string> RedirectTo(string code)
        {
            var link = await data.Find(code);
            if (link == null)
                return "/";

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
                Id = Guid.NewGuid(),
                Code = code,
                Title = link.Title,
                Url = link.Url,
                ValidTo = link.ValidTo
            });
            return code;
        }
    }
}
