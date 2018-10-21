using System;
using thunder.auth.Extensions.AuthenticationExtension;
using IdentityServer4;
using Microsoft.Extensions.DependencyInjection;

namespace thunder.auth.Extensions
{
    public static class CodeSavvyAuthenticationServiceExtension
    {
        public static IServiceCollection AddCodeSavvyAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication().AddCookie("GithubScheme")
                    .AddCodeSavvy("Github", options =>
                    {
                        options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                        options.CallbackPath = "/signin-codesavvy";
                        options.ClientId = "0562493230bcce65d58a";
                        options.ClientSecret = "0a2b28a36b9ec31879f19201c4f0dd45fda1523a";
                        options.ClaimsIssuer = "OAuth2-Github";
                        options.SaveTokens = true;
                        options.Scope.Add("read:user");
                        options.Scope.Add("user");
                        options.Scope.Add("repo");
                        options.Scope.Add("repo:invite");
                        options.Scope.Add("repo:status");
                        options.Scope.Add("admin:repo_hook");
                    });
            return services;
        }
    }
}
