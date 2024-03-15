using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;


namespace Data
{
    public class MigrationContext : Context
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //migration commands below. The last "-- --environment Production" piece is experimental and untested. it should set the env for aspnetcore which we would read and use when determining which secret to get
            //dotnet ef migrations add InitialMigration --context MigrationContext 
            //dotnet ef database update --context MigrationContext -- --environment Production
            var connectionString = GetConnectionString();
            optionsBuilder.UseSnowflake(connectionString);
            //optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PocDemosDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private string GetConnectionString()
        {
            var kvUri = "https://DemoAndPocKV.vault.azure.net";

            string environment = Environment.GetCommandLineArgs()[0]; //test this.
            Console.WriteLine(environment);
            var secretName = $"SnowflakeDBSecret{environment}";

            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            var secret = client.GetSecret(secretName).Value.Value; //this is how the offical azure keyvault package requires you to get a secret. kind of funny
            //var connectionString = $"blahblah;password={secret};blah";
            //return connectionString;
            var connectionString = "account=YOUR_ACCOUNT;host=UR_HOST.us-east-1.snowflakecomputing.com;user=UR_USER;password=UR_PASSWORD;db=TESTDB;schema=PUBLIC;warehouse=UR_WAREHOUSE";
            return secret;
        }
    }
}