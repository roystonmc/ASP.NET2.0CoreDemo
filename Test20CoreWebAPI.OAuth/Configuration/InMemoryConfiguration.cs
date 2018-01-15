using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace Test20CoreWebAPI.OAuth.Configuration
{
    public class InMemoryConfiguration
    {
        public InMemoryConfiguration()
        {
        }

        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[] {
                new ApiResource("socialNetwork", "Social Network")

            };
        }

        public static IEnumerable<Client> Clients()
        {
            return new[] {

                new Client{
                    ClientId = "socialNetwork",
                    ClientSecrets = new [] { new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new [] {"socialNetwork"}
                }
            };
        }

        public static IEnumerable<TestUser> Users()
        {
            return new[] {

                new TestUser {
                    SubjectId = "1",
                    Username = "rmcneill@gmail.com",
                    Password = "password"
                }
            };
        }
    }
}
