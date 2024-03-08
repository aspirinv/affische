using System;
using System.Collections.Generic;

namespace REvents.DTO
{
    public class EventsResponse
    {
        public string[] Types { get; set; }
        public string[] Artists { get; set; }

        public ICollection<EventsGroup> Events { get; set; }
    }

    public class EventsGroup
    {
        public DateTime Date { get; set; }
        public EventDescription[] Events { get; set; }
    }
}
