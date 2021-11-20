using AzureAdb2cDemo.ViewModels;
using AzureAdb2cDemo.Views;
using Microsoft.Identity.Client;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AzureAdb2cDemo
{
    public partial class App : PrismApplication
    {
        public static IPublicClientApplication AuthenticationClient { get; private set; }

        public static object UIParent { get; set; } = null;

        public App()
        {
            InitializeComponent();

            AuthenticationClient = PublicClientApplicationBuilder.Create(Constants.ClientId)
                .WithB2CAuthority(Constants.AuthoritySignin)
                .WithRedirectUri(Constants.RedirectUri)
                .Build();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<WorkflowPage, WorkflowPageViewModel>();
        }

        protected override void OnInitialized()
        {
        }
    }
}
