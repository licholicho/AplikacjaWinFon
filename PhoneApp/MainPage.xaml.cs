﻿using System;
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
      
            //TileItem tap = sender as TileItem;
            HubTile tap = sender as HubTile;
            string _tap = tap.Title.ToString();  //NullReferenceException occurs here

            switch (_tap)
            {
                //case "shareStatus_Tap":
                case "Add":
                    this.NavigationService.Navigate(new Uri("/AddPage.xaml", UriKind.Relative));
                    break;
                //case "shareLink_Tap":
                case "Mix":
                    this.NavigationService.Navigate(new Uri("/FindPage.xaml", UriKind.Relative));
                    break;
                case "Find":
                    this.NavigationService.Navigate(new Uri("/ListPage.xaml?ing1=" + "_", UriKind.Relative));
                    break;
            }
        }
    }
}
