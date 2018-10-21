using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;
using static thunder.auth.Extensions.AuthenticationExtension.CodeSavvyAuthenticationConstants;

namespace thunder.auth.Extensions.AuthenticationExtension
{
    public class CodeSavvyAuthenticationOptions : OAuthOptions
    {
        public CodeSavvyAuthenticationOptions()
        {
            ClaimsIssuer = CodeSavvyAuthenticationDefaults.Issuer;
            CallbackPath = new PathString(CodeSavvyAuthenticationDefaults.CallbackPath);
            AuthorizationEndpoint = CodeSavvyAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = CodeSavvyAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = CodeSavvyAuthenticationDefaults.UserInfoEndpoint;
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyID, "id");
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyLogin, "login");
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyEmail, "email");
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyName, "name");
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyURL, "url");
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyAvatar, "avatar_url");
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyRepos, "repos_url");
            ClaimActions.MapJsonKey(CodeSavvyClaimTypes.CodeSavvyToken, CodeSavvyClaimTypes.CodeSavvyToken);
        }

        public string UserEmailsEndpoint { get; set; } = CodeSavvyAuthenticationDefaults.UserEmailsEndpoint;
    }
}
