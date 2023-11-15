using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthenticationServer.API.Models;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationServer.API.Services.TokenGenerators
{
    public class AccessTokenGenerator
    {


        private readonly AuthenticationConfiguration _configuration;
        private readonly TokenGenerator _tokenGenerator;

        public AccessTokenGenerator(AuthenticationConfiguration configuration, TokenGenerator tokenGenerator)
        {
            _configuration = configuration;
            _tokenGenerator = tokenGenerator;
        }




        // This weill generate our token.
        public string GenerateToken(User user)
        {
            // Inside our jwt security constructor it will need paramaters.
            // 1. Issuer - the one that is issuing the jwt token
            // 2. Audience - is the one that will accept the jwt token.
            // In this case it's the same port. 
            // Later we will put them into a variable that can be access throughout our project.
            // 3. Claims - will contain the user information that is going to login.
            // 4. DateTime - this will tell 'til when our jwt is valid.
            // 5. Signin credentials - this will have the user credentials info.

            // Symmetric means that the key that we use to sign our 
            // jwt is the same key to be use once we verify our jwt.
            // We will generate our key using this site https://mkjwk.org/
            SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.AccessTokenSecret));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // In here we are creating a list of claims
            List<Claim> claims = new List<Claim>()
                {
                    new Claim("id", user.Id.ToString()),

                    // Claimtypes is given in Security.Claims library
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.Username)

                };

            return _tokenGenerator.GenerateToken(
                _configuration.AccessTokenSecret,
                _configuration.Issuer,
                _configuration.Audience,
                _configuration.AccessTokenExpirationMinutes,
                claims
                );


           /* JwtSecurityToken token = new JwtSecurityToken(
                _configuration.Issuer,
                _configuration.Audience,
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddMinutes(_configuration.AccessTokenExpirationMinutes),
                credentials
                );*/
            // Generate our token
            //return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}