using BookStoreApp.Blazor.Server.UI.Services.Authentication;
using BookStoreApp.Blazor.Server.UI.Services.Base;
using Microsoft.AspNetCore.Components;

namespace BookStoreApp.Blazor.Server.UI.Pages.Users
{
    public partial class Login
    {
        [Inject] 
        IAuthenticationService AuthService { get; set; }

        [Inject] 
        NavigationManager NavManager { get; set; }

        LoginUserDto LoginModel = new LoginUserDto();
        string message = string.Empty;
        public async Task HandleLogin()
        {
            try
            {
                var response = await AuthService.AuthenticateAsync(LoginModel);

                if (response)
                {
                    NavManager.NavigateTo("/");
                }

                message = "Invalid Credentials, Please Try Again";
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode >= 200 && ex.StatusCode <= 299)
                {

                }

                message = ex.Response;
            }
        }

    }
}