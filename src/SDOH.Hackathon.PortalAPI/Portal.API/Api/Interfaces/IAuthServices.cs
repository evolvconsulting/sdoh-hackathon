
namespace Portal.API.Interfaces
{
    public interface IAuthService
    {
        public Task<string> GetAdminToken();
        public Task<string> GetUserToken(string username, string password);
    }
}