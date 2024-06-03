using Google.Cloud.Firestore;
using Microsoft.Extensions.Options;
using REvents.Tools;

namespace REvents.DataSource
{
    public class FirebaseClient
    {
        public FirebaseClient(IOptions<FirebaseOptions> options)
        {
            this.options = options.Value;
        }
        private FirestoreDb _instance;
        private readonly FirebaseOptions options;

        public FirestoreDb CreateDb()
        {
            return _instance ??= new FirestoreDbBuilder
            {
                ProjectId = "munich-affiche",
                JsonCredentials = options.json
            }.Build();
        }
    }
}
