using Google.Cloud.Firestore;
using Microsoft.Extensions.Options;

namespace REvents.Data.DataSource
{
    public class FirebaseClient(IOptions<FirebaseOptions> options)
    {
        private FirestoreDb _instance;
        private readonly FirebaseOptions options = options.Value;

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
