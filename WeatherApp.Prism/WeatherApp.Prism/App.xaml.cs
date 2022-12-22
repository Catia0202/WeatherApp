using Prism;
using Prism.Ioc;
using WeatherApp.Prims.Services;
using WeatherApp.Prism.ViewModels;
using WeatherApp.Prism.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace WeatherApp.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<CurrentWeatherPage, CurrentWeatherPageViewModel>();
            containerRegistry.RegisterForNavigation<WeatherAppMasterDetailPage, WeatherAppMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<LocationsPage, LocationsPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
        }
    }
}
