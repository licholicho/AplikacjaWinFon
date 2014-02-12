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

        Drink _currentDrink = null;
        public DrinkPage()
        {
            InitializeComponent();


        }


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string s = "";

            if (NavigationContext.QueryString.TryGetValue("name", out s))
            {
                DatabaseClass db = new DatabaseClass();
                _currentDrink = db.GetDrink(s);
            }

            ShowDrink();
        }

        private void ShowDrink()
        {
            name.Text = _currentDrink.DrinkName;
            string[] ingr = _currentDrink.DrinkIngredients.Split('$');
            string[] weig = _currentDrink.IngredientsWeight.Split('$');
            string outer="";
            for (int i = 0; i < ingr.Count(); i++)
            {
                outer += ingr[i] + "\t" + weig[i] + "ml \n";
            }
            ingredients.Text = outer;
            description.Text = _currentDrink.DrinkDescription;
        }


        public string DisplayIngredients { get; set; }

        public string DisplayDescription { get; set; }
    }
}