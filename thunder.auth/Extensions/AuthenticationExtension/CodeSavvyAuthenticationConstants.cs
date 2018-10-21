using System;
namespace thunder.auth.Extensions.AuthenticationExtension
{
    public static class CodeSavvyAuthenticationConstants
    {
        public static class Claims {
            public const string Name = "name";
            public const string Url = "url";
            public const string Avatar = "avatar_url";
            public const string Email = "email";
            public const string Repos = "repos_url";
            public const string Token = "github_access_token";
        }
    }
}
