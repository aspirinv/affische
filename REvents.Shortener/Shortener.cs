using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using REvents.Data.DataSource;
using REvents.Data.Entities;


namespace REvents.Shortener
{
    public class Shortener(ILogger<Shortener> log, IShortenerData data, IOptions<ShortenerOptions> options)
    {
        [Function("srt")]
        public async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "srt/{code}")] HttpRequestData req, string code)
        {
            log.LogInformation($"Triggered Shortener function for code {code} ");

            var response = req.CreateResponse(HttpStatusCode.Redirect);

            var link = await data.Find(code);
            if (link == null)
            {
                response.Headers.Add("Location",options.Value.FallbackUrl);
                return response;
            }
            _ = data.RecordVisit(new ShortLinkVisit
            {
                VisitTime = DateTime.UtcNow,
                FromIP = "",//req..HttpContext.Connection.RemoteIpAddress?.ToString(),
                UserAgent = req.Headers.GetValues("User-Agent").FirstOrDefault(),
                LinkId = link.Id
            });

            log.LogInformation($"Found a record in db");

            if (link.ValidTo > DateTime.Today)
            {
                response.Headers.Add("Location", link.Url);
                return response;
            }

            log.LogInformation($"Redirecting to the URL");
            response.Headers.Add("Location", options.Value.FallbackUrl);
            return response;
        }
    }
}
