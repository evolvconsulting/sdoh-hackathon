// using Microsoft.AspNetCore.Authentication.Cookies;
// using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using dotnet8.Interfaces;
using dotnet8.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy  =>
        {
            policy.WithOrigins("https://localhost:3000", //frontend
                                "https://localhost:7011") //backend aka this
                                .AllowAnyMethod().AllowAnyHeader();
        });
});
builder.Services.AddControllers();

builder.Services.AddTransient<IClaimsTransformation, ClaimsTransformer>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API for frontend demos", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "bearer",
        In = ParameterLocation.Header,
        Description = "Please provide token with 'bearer ' prefix, (bearer {jwt token})",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { 
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
            }, 
            new List<string>() }
    });
});
builder.Services.AddHttpClient();

string keyVaultName = builder.Configuration["keyVaultName"];
//var client = new SecretClient(new Uri($"https://{keyVaultName}.vault.azure.net"), new DefaultAzureCredential());
var secret = "pUB+^ONZrg<w{[6%95Aa"; // client.GetSecret( builder.Configuration["SnowflakeDbSecretName"]).Value.Value; //this is how the offical azure keyvault package requires you to get a secret. kind of funny
var connectionString = $"ACCOUNT=LRB04982;host=aovnged-evolv_health.snowflakecomputing.com;user=SVC_EVOLV_SDOH;password={secret};db=EVOLV_SDOH;schema=PUBLIC;warehouse=COMPUTE_WH";

builder.Services.AddDbContext<Data.Models.ScaffoldedContext>(options => options.UseSnowflake(connectionString));
// X509Certificate2 certificate = new X509Certificate2("KeyCloakRealm.Public.crt");
// builder.Services
//     .AddAuthentication(x =>
//     {
//         x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//         x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//     }).AddJwtBearer(x =>
//     {
//         x.RequireHttpsMetadata = Convert.ToBoolean(builder.Configuration["Keycloak:require-https"]);
//         x.MetadataAddress = $"{builder.Configuration["Keycloak:server-url"]}/realms/master/.well-known/openid-configuration";
//         //x.Authority = $"{builder.Configuration["Keycloak:server-url"]}/realms/master"; //itest
//         //x.Audience = builder.Configuration["Keycloak:audience"]; itest
//         x.TokenValidationParameters = new TokenValidationParameters
//         {
//             //https://stackoverflow.com/questions/77084743/secure-asp-net-core-rest-api-with-keycloak
//             RoleClaimType = "role",
//             NameClaimType = $"{builder.Configuration["Keycloak:name_claim"]}", //only interesting if you want to map some field in the JWT token to the HttpContext.User.Identity.Name property
//             ValidAudience = $"{builder.Configuration["Keycloak:audience"]}",
//             IssuerSigningKey = new RsaSecurityKey(certificate.GetRSAPublicKey()), //itest
//             //ValidateIssuerSigningKey = false, //itest
//             // https://stackoverflow.com/questions/60306175/bearer-error-invalid-token-error-description-the-issuer-is-invalid
//             ValidateIssuer = Convert.ToBoolean($"{builder.Configuration["Keycloak:validate-issuer"]}")
//         };
//     });
        
// builder.Services.AddAuthorization(o => {
//     o.DefaultPolicy = new AuthorizationPolicyBuilder()
//         .RequireAuthenticatedUser()
//         .Build();
//     o.AddPolicy("default-api-access", policy => policy
//         .RequireAuthenticatedUser().RequireClaim(ClaimTypes.Role, "demo-api-default-api-access"));
// });
// builder.Services.AddScoped<IAuthService, AuthService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => options.EnableTryItOutByDefault());
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
