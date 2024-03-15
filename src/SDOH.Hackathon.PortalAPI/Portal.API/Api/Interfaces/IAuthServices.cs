
namespace dotnet8.Interfaces
{
    public interface IAuthService
    {
        public Task<string> GetAdminToken();
        public Task<string> GetUserToken(string username, string password);
    }
}