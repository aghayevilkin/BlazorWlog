using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wlog_Client.Helper;
using Wlog_Client.Service.IService;

namespace Wlog_Client.Pages.Authentication
{
    public partial class Register
    {
        private UserRequestDTO UserForRegistration = new UserRequestDTO();
        public bool IsProcessing { get; set; } = false;
        public bool ShowRegistrationErrors { get; set; }
        public IEnumerable<string> Errors { get; set; }

        [Inject]
        public IAuthenticationService authenticationService { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Inject]
        public IJSRuntime jsRuntime { get; set; }


        private async Task RegisterUser()
        {
            ShowRegistrationErrors = false;
            IsProcessing = true;
            var result = await authenticationService.RegisterUser(UserForRegistration);
            if (result.IsRegisterationSuccessful)
            {
                IsProcessing = false;
                await jsRuntime.ToastrSuccess("Qediyyatdan keçdiniz");
                navigationManager.NavigateTo("/login");
            }
            else
            {
                IsProcessing = false;
                Errors = result.Errors;
                ShowRegistrationErrors = true;
            }
        }
    }
}
