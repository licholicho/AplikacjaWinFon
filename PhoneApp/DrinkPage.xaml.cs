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
    public partial class DrinkPage : PhoneApplicationPage
    {

        Drink _currentDrink;
        public DrinkPage()
        {
            InitializeComponent();

//ContentPanel.DataContext = _currentDrink;
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }



        public string DisplayIngredients { get; set; }

        public string DisplayDescription { get; set; }
    }
}