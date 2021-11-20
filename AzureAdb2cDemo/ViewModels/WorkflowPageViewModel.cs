using Prism.Mvvm;
using Prism.Navigation;
using System.Diagnostics;

namespace AzureAdb2cDemo.ViewModels
{
    public class WorkflowPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService navigationService;

        public string Status => "Hurray Login successful!";

        public WorkflowPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Debug.WriteLine($"URI: {navigationService.GetNavigationUriPath()}");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Debug.WriteLine($"URI: {navigationService.GetNavigationUriPath()}");
        }
    }
}
