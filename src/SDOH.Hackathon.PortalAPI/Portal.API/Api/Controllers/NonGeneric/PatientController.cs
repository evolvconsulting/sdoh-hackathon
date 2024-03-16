using Data;
using dotnet8.Models;
using dotnet8.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using Data.Models;
using Data.Interfaces;
using System.Text;

namespace dotnet8.Controllers
{
    [ApiController]
    [Route("patients")]
    public class PatientController : BaseController<Patient>
    {
        IHttpClientFactory _clientFactory;
        IAuthService _authService;
        public PatientController(ScaffoldedContext context, IConfiguration configuration, IHttpClientFactory clientFactory, IAuthService authService) : base(context, configuration) { 
            _clientFactory = clientFactory;
            _authService = authService;
        }

        // [HttpPut]
        // [Route("register")]
        // [ProducesResponseType<object>(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status404NotFound)]
        // public async Task<IActionResult> Register([FromBody]UserRegistrationEntity entity)
        // {
        //     var adminToken = "";
        //     try{
        //         adminToken =  await _authService.GetAdminToken();
        //     }
        //     catch(HttpRequestException e){
        //         Console.WriteLine(e.Message);
        //         return StatusCode((int)e.StatusCode, $"Failed to get AdminToken: {e.Message}");
        //     }
        //     try{
        //         using (var client = _clientFactory.CreateClient())
        //         {
        //             client.DefaultRequestHeaders.Add("Authorization", "Bearer " + adminToken);
        //             var userAddResponse = await client.PostAsync(_config.GetSection("KeyCloak").GetSection("AddUserEndpoint").Value, CreateUserPostContent(entity));
        //             var a = await userAddResponse.Content.ReadAsStringAsync();
        //             if(!userAddResponse.IsSuccessStatusCode){
        //                 return StatusCode((int)userAddResponse.StatusCode, a);
        //             }
        //         }
        //     }
        //     catch(Exception e){
        //         Console.WriteLine(e.Message);
        //     }
        //     return await base.Put(new Patient { 
        //         Id = entity.Id,
        //         Username = entity.Username,
        //         Email = entity.Email,
        //         FirstName = entity.FirstName,
        //         LastName = entity.LastName 
        //     });
        // }

        [HttpPut]
        [Route("login")]
        [ProducesResponseType<object>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Login(string username, [FromBody]string password)
        {            
            string token = "";
            try{
                token = await _authService.GetUserToken(username, password);
            }
            catch(HttpRequestException e){
                Console.WriteLine(e.Message);
                return StatusCode((int)e.StatusCode, e.Message);
            }
            return Ok(token);
        }

        private StringContent CreateUserPostContent(UserRegistrationEntity user)
        {
            var userCred = new {
                type = "password",
                value = user.Password,
                temporary = false
            };
            var userRepresentation = new {
                enabled = true,
                username = user.Username,
                email = user.Email,
                firstName = user.FirstName,
                lastName = user.LastName,
                credentials =  new [] { userCred }
            };

            var postContent = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(userRepresentation),
                Encoding.UTF8,
                Application.Json); 
            
            return postContent;
        }

        //When a user logs in via keycloak they are redirected. 
        //This handles the redirect and exchanges the auth code from keycloak for an access token
        // public async Task<IActionResult> LoginCallback()
        // {
        //     var authResult = await HttpContext.AuthenticateAsync(OpenIdConnectDefaults.AuthenticationScheme);
        //     //var authResult = await AuthenticateAsync(this Microsoft.AspNetCore.Http.HttpContext context, OpenIdConnectDefaults.AuthenticationScheme);
        //     if (authResult?.Succeeded != true)
        //     {
        //         // Handle failed authentication
        //         return RedirectToAction("Login");
        //     }

        //     // Get the access token and refresh token
        //     var accessToken = authResult.Properties.GetTokenValue("access_token");
        //     var refreshToken = authResult.Properties.GetTokenValue("refresh_token");

        //     // Save the tokens to the user's session or database
        //     HttpContext.Session.SetString("access_token", accessToken);
        //     HttpContext.Session.SetString("refresh_token", refreshToken);

        //     // Redirect the user to the desired page
        //     return RedirectToAction("Index");
        // }
    }
}
