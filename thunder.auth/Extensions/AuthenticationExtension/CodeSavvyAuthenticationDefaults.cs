using System;
namespace thunder.auth.Extensions.AuthenticationExtension
{
    public class CodeSavvyAuthenticationDefaults
    {
        public const string AuthenticationScheme = "CodeSavvysherpa";
        public const string DisplayName = "Code Savvysherpa";
        public const string Issuer = "CodeSavvysherpa";
        public const string CallbackPath = "/signin-codesavvy";
        public const string AuthorizationEndpoint = "https://code.savvysherpa.com/login/oauth/authorize";
        public const string TokenEndpoint = "https://code.savvysherpa.com/login/oauth/access_token";
        public const string UserInfoEndpoint = "https://code.savvysherpa.com/api/v3/user";
        public const string UserEmailsEndpoint = "https://code.savvysherpa.com/api/v3/emails";
    }
}
