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
    public partial class AddPage : PhoneApplicationPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void TextBoxEventName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Camera_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Gallery_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Save_Click(object sender, EventArgs e)
        {
/*
            IList<Drink> drinkList = databaseClass.GetDrinksList();

            //eventsListPerDay = TransformToEventsListPerDay(eventsList);
            IEnumerable<Drink> queryListDrinks = drinkList;//.OrderBy(evt => evt.DrinkName);
            eventsListPerDay = queryListDrinks.ToList();
 * */
            Drink add = new Drink();
            string name = NAME.Text;
            string ingr1 = ing1.Text;
            string wei1 = we1.Text;
            string ingr2 = ing2.Text;
            string wei2 = we2.Text;
            string ingr3 = ing3.Text;
            string wei3 = we3.Text;
            string descr = desc.Text;
            if (!((String.IsNullOrWhiteSpace(name)) || (String.IsNullOrWhiteSpace(ingr1)) || (String.IsNullOrWhiteSpace(wei1))))
            {
                string ingredients = ingr1;
                string weights = wei1;
                add.DrinkName = name;
                if (!(String.IsNullOrWhiteSpace(ingr2)) && !(String.IsNullOrWhiteSpace(wei2)))
                {
                    ingredients += "$" + ingr2;
                    weights += "$" + wei2;
                }
                if (!(String.IsNullOrWhiteSpace(ingr3)) && !(String.IsNullOrWhiteSpace(wei3)))
                {
                    ingredients += "$" + ingr3;
                    weights += "$" + wei3;
                }
                add.DrinkIngredients = ingredients;
                add.IngredientsWeight = weights;
                if (!String.IsNullOrWhiteSpace(descr))
                {
                    add.DrinkDescription = descr;
                }
                DatabaseClass databaseClass = new DatabaseClass();
                databaseClass.AddDrink(add);
             //   System.Diagnostics.Debug.WriteLine("ADD " + add.DrinkName);
                NavigationService.Navigate(new Uri("/ListPage.xaml?ing1=" + "_", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Please give name and one ingredient !");
            }


        }



    }
}