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
    public partial class FindPage : PhoneApplicationPage
    {
        private ShakeDetector _shakeDetector;

        public FindPage()
        {
            InitializeComponent();
            _shakeDetector = new ShakeDetector();
            _shakeDetector.ShakeEvent += new EventHandler<RoutedEventArgs>(_shakeDetector_ShakeEvent);
            _shakeDetector.Start();
        }

        void _shakeDetector_ShakeEvent(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(() =>
            {
                NavigationService.Navigate(new Uri("/ListPage.xaml?ing1=" + textBox1.Text
                                                              + "&ing2=" + textBox2.Text
                                                              + "&ing3=" + textBox3.Text, UriKind.Relative));
            });

        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var lastPage = NavigationService.BackStack.FirstOrDefault();
            if (lastPage != null && lastPage.Source.ToString() != "/MainPage.xaml")
            {
                NavigationService.RemoveBackEntry();
            }
        }
    }
}