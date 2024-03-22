using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;

public class ClaimsTransformer : IClaimsTransformation
{
    public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        ClaimsIdentity claimsIdentity = (ClaimsIdentity)principal.Identity;

        // flatten realm_access because Microsoft identity model doesn't support nested claims
        // by map it to Microsoft identity model, because automatic JWT bearer token mapping already processed here
        if (claimsIdentity.IsAuthenticated && claimsIdentity.HasClaim((claim) => claim.Type == "realm_access"))
        {
            var resourceAccessClaim = claimsIdentity.FindFirst((claim) => claim.Type == "resource_access");

            
            var typee = resourceAccessClaim.Type;
            var a = resourceAccessClaim.ValueType;
            var resourceAccessAsDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string[]>>>(resourceAccessClaim.Value);
            var newClaimsList = new List<Claim>();
            foreach (var clientClaimsObject in resourceAccessAsDict)
            {
                foreach(var clientclaim in clientClaimsObject.Value["roles"]){
                    var newClaim = new Claim(ClaimTypes.Role, $"{clientClaimsObject.Key}-{clientclaim}");
                    //newClaimsList.Add(newClaim);
                    claimsIdentity.AddClaim(newClaim);
                }
            }

            var realmAccessClaim = claimsIdentity.FindFirst((claim) => claim.Type == "realm_access");
            var realmAccessAsDict = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(realmAccessClaim.Value);
            if (realmAccessAsDict["roles"] != null)
            {
                foreach (var role in realmAccessAsDict["roles"])
                {
                    var newClaim = new Claim(ClaimTypes.Role, role);
                    newClaimsList.Add(newClaim);
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, role));
                    //claimsIdentity.AddClaim(new Claim(ClaimTypes., newClaim));
                }
            }
        }

        return Task.FromResult(principal);
    }
}