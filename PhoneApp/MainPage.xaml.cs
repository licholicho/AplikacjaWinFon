using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApp
{
    public partial class MainPage : PhoneApplicationPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void hubTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            HubTile tap = sender as HubTile;
            string _tap = tap.Title.ToString(); 

            switch (_tap)
            {
                case "Add":
                    this.NavigationService.Navigate(new Uri("/AddPage.xaml", UriKind.Relative));
                    break;
                case "Mix":
                    this.NavigationService.Navigate(new Uri("/FindPage.xaml", UriKind.Relative));
                    break;
                case "Find":
                    this.NavigationService.Navigate(new Uri("/ListPage.xaml?ing1=" + "_", UriKind.Relative));
                    break;
                case "About":
                    this.NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
                    break;
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            var lastPage = NavigationService.BackStack.FirstOrDefault();
            if (lastPage != null && lastPage.Source.ToString() == "/AddPage.xaml")
            {
                NavigationService.RemoveBackEntry();
            }
        }
    }
}
