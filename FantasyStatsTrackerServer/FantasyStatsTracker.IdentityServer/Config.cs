using System.Collections.Generic;
using IdentityServer4.Models;

namespace FantasyStatsTracker.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> Apis => new List<ApiResource>
        {
            new ApiResource("characters", "Characters")
        };
        
        public static IEnumerable<Client> Clients => new List<Client>
        {
            new Client
            {
                ClientId = "FantasyStatsTrackerMobile",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("changeMe".Sha256())
                },
                AllowedScopes = { "characters" }
            }
        };
    }
}