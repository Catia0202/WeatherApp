using System.Collections.ObjectModel;
using WeatherApp.Prism.Models;
using Xamarin.Forms;

namespace WeatherApp.Prism.Views
{
    public partial class AboutPage : CarouselPage
    {
        ObservableCollection<AboutItem> myList;
        public AboutPage()
        {
            InitializeComponent();

            myList = new ObservableCollection<AboutItem>
            {
                new AboutItem{Name="Informations Source", Status="All weather informations displayed in this app come from an api of this site called 'Open Weather Map ' \n\n Link: https://openweathermap.org", Image="https://apps-cdn.athom.com/app/nu.baretta.openweathermap/45/f865ce42-3032-45f1-85fa-3f0034f622fc/assets/images/large.png"},
                new AboutItem{Name="Creator", Status="This app was developed by Cátia Santos, current student in 'Cinel'", Image="https://cinel.pt/appv2/Portals/0/cinel_logo_horizontal.png"},
                new AboutItem{Name="App", Status="This app helps you about the weather around the world, where you can choose some citys or countrys!", Image="https://cdn-icons-png.flaticon.com/512/1163/1163734.png"}

            };
            ItemsSource = myList;
        }
    }
}
