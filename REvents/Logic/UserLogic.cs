using Microsoft.IdentityModel.Tokens;
using REvents.DataSource;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace REvents.Logic
{
    public class UserLogic
    {
        private readonly IUserData userData;
        private readonly IConfiguration configuration;

        public UserLogic(IUserData userData, IConfiguration configuration)
        {
            this.userData = userData;
            this.configuration = configuration;
        }

        public async Task<string> Login(string login, string password)
        {
            var user = await userData.Authenticate(login, password);
            if (user == null) return null;
            var key = Encoding.ASCII.GetBytes(configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                [
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Login),
                    new Claim(ClaimTypes.Role,"admin")
                ]),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
