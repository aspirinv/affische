using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;

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

    [FirestoreData]
    public class ShortLink
    {
        [FirestoreDocumentId]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Code { get; set; }
        [FirestoreProperty]
        public string Title { get; set; }
        [FirestoreProperty]
        public DateTime ValidTo { get; set; }
        [FirestoreProperty]
        public string Url { get; set; }
    }

    [FirestoreData]
    public class ShortLinkVisit
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public DateTime VisitTime { get; set; }
        [FirestoreProperty]
        public string FromIP { get; set; }

        [FirestoreProperty]
        public string UserAgent { get; set; }
        [FirestoreProperty]
        public string LinkId { get; set; }


    }
}
