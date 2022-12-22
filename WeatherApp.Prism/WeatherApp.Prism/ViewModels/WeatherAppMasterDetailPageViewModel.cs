using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WeatherApp.Prism.ItemViewModel;
using WeatherApp.Prism.Models;
using WeatherApp.Prism.Views;

namespace WeatherApp.Prism.ViewModels
{
	public class WeatherAppMasterDetailPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;

        public WeatherAppMasterDetailPageViewModel(INavigationService navigationService) :base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
        }

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }
        private void LoadMenus()
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "Homeicon",
                    PageName = $"{nameof(CurrentWeatherPage)}",
                    Title = "Home"
                },
                 new Menu
                {
                    Icon = "locationicon",
                    PageName = $"{nameof(LocationsPage)}",
                    Title = "Locations"
                },
                   new Menu
                {
                    Icon = "abouticon",
                    PageName = $"{nameof(AboutPage)}",
                    Title = "About"
                },
                new Menu
                {
                    Icon = "dooricon",
                    PageName = $"{nameof(LoginPage)}",
                    Title = "Logout"
                },
            };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    Title = m.Title,
                    PageName = m.PageName
                }).ToList());
        }
    }
    
}
