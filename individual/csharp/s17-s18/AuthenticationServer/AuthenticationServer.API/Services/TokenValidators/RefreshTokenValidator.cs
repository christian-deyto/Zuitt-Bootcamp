using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using AuthenticationServer.API.Models;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationServer.API.Services.TokenValidators
{
    public class RefreshTokenValidator
    {
        private readonly AuthenticationConfiguration _configuration;

        public RefreshTokenValidator(AuthenticationConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool Validate(string refreshToken)
        {
            // TokenValidationParamters allows us to configure our Jwt Authentication. So we will just copy and paste our
            // previous code in DataServer.
            TokenValidationParameters validationParameters = new TokenValidationParameters()
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.RefreshTokenSecret)),
                ValidIssuer = _configuration.Issuer,
                ValidAudience = _configuration.Audience,
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ClockSkew = TimeSpan.Zero
            }; ;

            // It is designed for creating and validating Json Web Tokens
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            try
            {

                // This validates our token and will out/output our validated token. We just have to specify it here. 
                tokenHandler.ValidateToken(refreshToken, validationParameters, out SecurityToken validatedToken);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}