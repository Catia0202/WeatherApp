﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace WeatherApp.Prism.ViewModels
{
	public class LocationsPageViewModel : ViewModelBase 
    { 
        public LocationsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Locations";
        }
	}
}
