﻿using IdentityServer4.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using thunder.auth.ViewModels.Home;

namespace thunder.auth.Controllers
{
    public class HomeController : Controller
    {

        private readonly IIdentityServerInteractionService _interaction;
        private readonly IHostingEnvironment _environment;
        public HomeController(IIdentityServerInteractionService interaction, IHostingEnvironment environment)
        {
            _interaction = interaction;
            _environment = environment;

        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Shows the error page
        /// </summary>
        public async Task<IActionResult> Error(string errorId)
        {
            var vm = new ErrorViewModel();

            // retrieve error details from identityserver
            var message = await _interaction.GetErrorContextAsync(errorId);
            if (message != null)
            {
                vm.Error = message;

                if (!_environment.IsDevelopment())
                {
                    // only show in development
                    message.ErrorDescription = null;
                }
            }

            return View("Error", vm);
        }
    }
}
