using Google.Cloud.Firestore;
using System;

namespace REvents.Entities
{

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
