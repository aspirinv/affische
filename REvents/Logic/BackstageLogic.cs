using Microsoft.Extensions.Logging;
using REvents.DataSource;
using REvents.DTO;
using REvents.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.Logic
{
    public class BackstageLogic
    {
        private readonly BackstageClient client;
        private readonly ILogger<BackstageLogic> log;

        public BackstageLogic(BackstageClient client, ILogger<BackstageLogic> log)
        {
            this.client = client;
            this.log = log;
        }

        public async Task<ICollection<EventDescription>> GetEvents()
        {
            log.LogInformation("Start collecting backstage events");
            return (await client.GetEvents())
                .Select(e => Convert(e))
                .Where(e => e != null)
                .ToList();
        }

        private EventDescription Convert(BackstageEvent e)
        {
            try
            {
                var (title, details) = e.GetTitles();

                return new EventDescription
                {
                    Id = e.id,
                    Title = title,
                    Details = details,
                    Types = e.GetTypes(),
                    Date = e.GetDate(),
                    url = e.url,
                    Venue = e.venue
                };
            }
            catch(Exception ex)
            {
                log.LogError(ex, $"Can't convert backstage event {e.id}");
                return null;
            }
        }
    }
}
