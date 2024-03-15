
using dotnet8.Interfaces;
using dotnet8.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using System.Text;


namespace dotnet8.Services
{
    public class AuthService : IAuthService
    {
        protected readonly IConfiguration _config;
        IHttpClientFactory _clientFactory;
        public AuthService(IConfiguration configuration, IHttpClientFactory clientFactory) 
        { 
            _config = configuration;
            _clientFactory = clientFactory;
        }
        
        public Task<string> GetAdminToken()
        {
            return GetToken(_config.GetSection("KeyCloak").GetSection("Username").Value, _config.GetSection("KeyCloak").GetSection("Password").Value, "admin-cli");
        }
        
        public Task<string> GetUserToken(string username, string password)
        {
            return GetToken(username, password, "demo-api");
        }

        private async Task<string> GetToken(string username, string password, string client_id)
        {
            var token = "";
            using (var client = _clientFactory.CreateClient())
            {
                var tokenResponse = await client.PostAsync(_config.GetSection("KeyCloak").GetSection("TokenEndpoint").Value, CreateTokenContent(client_id, username, password));
                
                if(!tokenResponse.IsSuccessStatusCode){
                    throw new HttpRequestException(await tokenResponse.Content.ReadAsStringAsync(), new Exception(tokenResponse.ReasonPhrase), tokenResponse.StatusCode);
                    //return StatusCode((int)tokenResponse.StatusCode, await tokenResponse.Content.ReadAsStringAsync());
                }  
                var body = await tokenResponse.Content.ReadAsStringAsync();
                token = (JsonConvert.DeserializeObject<TokenResponse>(body)).access_token;
            }         
            return token;
        }
        private FormUrlEncodedContent CreateTokenContent(string client_id, string username, string password)
        {
            var dictionaryContent = new Dictionary<string, string> {
                {"client_id", client_id},
                {"username", username},
                {"password", password},
                {"grant_type", "password"},
            };
            var formContent = new FormUrlEncodedContent(dictionaryContent);
            
            return formContent;
        }
        
    }
}
