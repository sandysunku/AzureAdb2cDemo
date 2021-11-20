using AzureAdb2cDemo.Commands;
using Microsoft.Identity.Client;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AzureAdb2cDemo.ViewModels
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public ICommand LoginCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            LoginCommand = new AsyncCommand(Login);
            _navigationService = navigationService;
        }

        private async Task Login()
        {
            AuthenticationResult result;
            try
            {
                result = await App.AuthenticationClient
                    .AcquireTokenInteractive(Constants.Scopes)
                    .WithPrompt(Prompt.SelectAccount)
                    .WithParentActivityOrWindow(App.UIParent)
                    .WithUseEmbeddedWebView(true)
                    .ExecuteAsync();

                if (result != null)
                {
                    _navigationService.NavigateAsync("/WorkflowPage");
                }
            }
            catch (MsalException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }

}
