using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationServer.API.Services.TokenGenerators
{
    public class TokenGenerator
    {
        public string GenerateToken(string secretKey, string issuer, string audience, int expirationMinutes,
            IEnumerable<Claim> claims = null)
        {
            // Inside our jwt security constructor it will need paramaters.
            // Issuer - the one that is issuing the jwt token
            // Audience - is the one that will accept the jwt token.
            // In this case it's the same port. Later we will put them into a variable that can be access throughout our project.

            // DateTime - this will tell 'til when our jwt is valid.
            // Signin credentials - this will have the user credentials info.

            // Symmetric means that the key that we use to sign our jwt is the same key to be use once we verify our jwt.
            // We will generate our key using this site https://mkjwk.org/
            SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            JwtSecurityToken token = new JwtSecurityToken(
                issuer,
                audience,
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddMinutes(expirationMinutes),
                credentials
                );
            // Generate our token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
