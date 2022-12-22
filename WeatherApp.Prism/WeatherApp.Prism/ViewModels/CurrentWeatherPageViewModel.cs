using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherApp.Prism.ViewModels
{
	public class CurrentWeatherPageViewModel : ViewModelBase
	{
        public CurrentWeatherPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Weather Details";
        }
    }
}
