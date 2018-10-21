using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace thunder.auth.Extensions.AuthenticationExtension
{
    public static class CodeSavvyAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="CodeSavvyAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GitHub authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddCodeSavvy(this AuthenticationBuilder builder)
        {
            return builder.AddCodeSavvy(CodeSavvyAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="CodeSavvyAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GitHub authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddCodeSavvy(
            this AuthenticationBuilder builder,
            Action<CodeSavvyAuthenticationOptions> configuration)
        {
            return builder.AddCodeSavvy(CodeSavvyAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="CodeSavvyAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GitHub authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the GitHub options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddCodeSavvy(
            this AuthenticationBuilder builder, string scheme,
            Action<CodeSavvyAuthenticationOptions> configuration)
        {
            return builder.AddCodeSavvy(scheme, CodeSavvyAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="CodeSavvyAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GitHub authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the GitHub options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddCodeSavvy(
             this AuthenticationBuilder builder,
             string scheme,  string caption,
            Action<CodeSavvyAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<CodeSavvyAuthenticationOptions, CodeSavvyAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}
