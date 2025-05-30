﻿using Google.Cloud.Firestore;

namespace REvents.Data.Entities
{
    [FirestoreData]

    public class User
    {
        [FirestoreDocumentId]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Login { get; set; }
        [FirestoreProperty]
        public string Hash { get; set; }
    }
}
