using AuthenticationServer.API.Models;

namespace AuthenticationServer.API.Services.RefreshTokenRepositories
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken> GetByToken(string refreshToken);
        Task Create(RefreshToken refreshToken);
    }
}
