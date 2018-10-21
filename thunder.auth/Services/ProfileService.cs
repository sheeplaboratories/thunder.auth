using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using thunder.auth.Data;

namespace thunder.auth.Services
{
    public class ProfileService : IProfileService
    {
        private readonly UserManager<IdentityUser> _store;
        public ProfileService(UserManager<IdentityUser> store)
        {
            _store = store;
        }
        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var userId = context.Subject.Claims.SingleOrDefault(obj => obj.Type == "sub").Value;
            var user = _store.FindByIdAsync(userId).Result;
            if(user != null)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim("email", user.Email)
                };
                context.IssuedClaims.AddRange(claims.AsEnumerable());
            }
            return Task.CompletedTask;
        }

        public Task IsActiveAsync(IsActiveContext context)
        {
            var userId = context.Subject.Claims.SingleOrDefault(obj => obj.Type == "sub").Value;
            var user = _store.FindByIdAsync(userId).Result;
            context.IsActive = user != null;
            return Task.CompletedTask;
        }
    }
}
