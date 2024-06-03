using Google.Cloud.Firestore;
using Microsoft.Extensions.Options;
using REvents.Entities;
using REvents.Tools;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace REvents.DataSource
{
    public class FirebaseUserData : FirebaseClient, IUserData
    {
        public FirebaseUserData(IOptions<FirebaseOptions> options) : base(options)
        {
        }

        public async Task<User> Authenticate(string login, string password)
        {
            return (await Users()
                .Where(Filter.And(Filter.EqualTo("Login", login), Filter.EqualTo("Hash", password.ToSha256())))
                .Limit(1).StreamAsync()
                .FirstOrDefaultAsync())
                ?.ConvertTo<User>();
        }
        private CollectionReference Users() => CreateDb().Collection("users");
    }

    public interface IUserData
    {
        Task<User> Authenticate(string login, string password);
    }
}
