using System;
using AuthenticationServer.API.Models;

namespace AuthenticationServer.API.Services.RefreshTokenRepositories
{
    public class InMemoryRefreshTokenRepository : IRefreshTokenRepository
    {
        // This will hold our refresh token that we create.
        private readonly List<RefreshToken> _refreshTokens = new List<RefreshToken>();

        public Task Create(RefreshToken refreshToken)
        {
            // Giving our refresh token a unique identifier
            refreshToken.Id = Guid.NewGuid();

            // Adding our token to our list.
            _refreshTokens.Add(refreshToken);

            return Task.CompletedTask;

        }

        public Task<RefreshToken> GetByToken(string token) 
        {
            RefreshToken refreshToken = _refreshTokens.FirstOrDefault(r => r.Token == token);

            return Task.FromResult(refreshToken);
        }
    }
}