using System;
using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace thunder.auth
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>(){
                new TestUser{
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b97c7",
                    Username = "judedaryl",
                    Password = "password",
                    Claims = new List<Claim>{
                        new Claim("given_name", "daryl"),
                        new Claim("family_name", "clarino"),
                        new Claim("address","my address"),
                        new Claim("role", "member"),
                    }
                },
                new TestUser{
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b97c2",
                    Username = "andrea",
                    Password = "password",
                    Claims = new List<Claim>{
                        new Claim("given_name", "andrea"),
                        new Claim("family_name", "sacdalan"),
                        new Claim("address","my address"),
                        new Claim("role", "admin")
                    }
                }
            };
        }

        // scopes
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>() {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),
                new IdentityResource("roles", "Your role(s)", new List<string>() {"role"})
            };
        }

        // clients
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client {
                    ClientName = "Thunder Chat App",
                    ClientId = "thunderchatapp",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    RedirectUris = new List<string>() {
                        "https://chat.thunder.com"
                    },
                    
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        "chat"
                    },
                    PostLogoutRedirectUris = new List<string>() {
                        "https://localhost:5100/signout-callback-oidc"
                    },
                    ClientSecrets = {
                        new Secret("secret".Sha256())
                    },
                    AccessTokenLifetime = 5256000,
                    AuthorizationCodeLifetime = 5256000,
                    ConsentLifetime = 5256000,
                    IdentityTokenLifetime = 5256000,
                    AbsoluteRefreshTokenLifetime = 5256000,
                    SlidingRefreshTokenLifetime = 5256000
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>{
                new ApiResource("chat", "Thunder Chat", new List<string>() {"role"})
            };
        }


    }
}