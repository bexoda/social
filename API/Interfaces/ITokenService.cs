using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CreeateToken(AppUser user)
    }
}