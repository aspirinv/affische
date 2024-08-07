﻿using System;

namespace REvents.DTO
{
    public class ShortLinkHeader
    {
        public string Title { get; set; }
        public DateTime ValidTo { get; set; }
        public string Url { get; set; }
    }
    public class VisiterData
    {
        public string IP { get; set; }
        public string UserAgent { get; set; }
    }

    public class ShortLinkInfo
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime ValidTo { get; set; }
        public string Url { get; set; }
        public int VisitsAmount { get; set; }
    }

}
