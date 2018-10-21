using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;

namespace thunder.auth.Extensions
{
    public static class ReverseProxyExtension
    {
        public static IApplicationBuilder UseNginxReverseProxy(this IApplicationBuilder app)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            return app;
        }
    }
}
