using System;

namespace REvents.DTO
{
    public class ShortLinkHeader
    {
        public string Title { get; set; }
        public DateTime ValidTo { get; set; }
        public string Url { get; set; }
    }

    public class ShortLink
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime ValidTo { get; set; }
        public string Url { get; set; }
        public ShortLinkVisit Visits { get; set; }
    }
    public class ShortLinkVisit
    {
        public DateTime VisitTime { get; set; }
        public string FromIP { get; set; }

    }
}
