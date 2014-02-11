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
        // Constructor
        private ShakeDetector _shakeDecetor;
        public MainPage()
        {
            InitializeComponent();
            _shakeDecetor = new ShakeDetector();
            _shakeDecetor.ShakeEvent += new EventHandler<EventArgs>(_shakeDecetor_ShakeEvent);
            _shakeDecetor.Start();
        }

        void _shakeDecetor_ShakeEvent(object sender, EventArgs e)
        {
            this.Dispatcher.BeginInvoke(() =>
                                            {
                                              //  Storyboard shakeAnimation = Resources["ShakeAnimation"] as Storyboard;
                                               // shakeAnimation.Begin();
                                                NavigationService.Navigate(new Uri("/SecondPage.xaml", UriKind.Relative));
                                            });
            
        }

        private void Shake_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddPage.xaml", UriKind.Relative));
        }
    }
}
