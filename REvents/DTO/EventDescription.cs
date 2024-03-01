using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.DTO
{
    public class EventDescription
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }
        public string url { get; set; }
        public string[] Types { get; set; }
    }
}
