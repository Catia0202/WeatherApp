using System.Collections.Generic;
using WeatherApp.Prism.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WeatherApp.Prism.Views
{
    public partial class LocationsPage : ContentPage
    {
        public LocationsPage()
        {
            InitializeComponent();
            List<LocationItem> myList = new List<LocationItem>
            {
              new LocationItem{Name="Japan", Icon ="Japan"},
              new LocationItem{Name="Italy", Icon ="Italy"},
              new LocationItem{Name="Canada", Icon ="Canada"},
              new LocationItem{Name="Spain", Icon ="Spain"},
              new LocationItem{Name="Detroit", Icon ="Detroit"},
              new LocationItem{Name="London", Icon ="London"},
              new LocationItem{Name="Lisbon", Icon ="Lisbon"},
              new LocationItem{Name="NewYork", Icon ="NewYork"},
              new LocationItem{Name="Tokyo", Icon ="Tokyo"},

            };
            myListView.ItemsSource = myList;
        }

        async void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var locationitem = e.SelectedItem as LocationItem;
            await Navigation.PushAsync(new CurrentWeatherPage(locationitem.Name, locationitem.Icon));
        }
    }
}
