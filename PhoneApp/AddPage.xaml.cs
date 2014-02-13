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

        List<StackPanel> listIngredients;
       
        ListBox listbox = new ListBox();
        int howMany;
        TextBox desc;
        TextBox namae;

        public AddPage()
        {
            InitializeComponent();
            listIngredients = new List<StackPanel>();
            howMany = 0;
            List<PivotItem> Listpivotitem = new List<PivotItem>();
            Listpivotitem.Add(new PivotItem());
            namae = new TextBox();

            StackPanel sp = AddName();
            //sp.Children.Add(new TextBox());
            Listpivotitem[0].Header = sp;

            Listpivotitem[0].Content = listbox;

            pivotControl.Items.Add(Listpivotitem[0]);
            listbox.Items.Add(AddIngredient());
            desc = new TextBox();
        }

        private StackPanel AddIngredient()
        {
            StackPanel nowy = new StackPanel();
            nowy.Orientation = System.Windows.Controls.Orientation.Horizontal;
            StackPanel ingredient = new StackPanel();
            StackPanel volume = new StackPanel();
            TextBlock ingrTitle = new TextBlock();
            ingrTitle.Foreground = new SolidColorBrush(Colors.Yellow);
            ingrTitle.Height = 30;
            ingrTitle.Width = 256;
            ingrTitle.Text = "Ingredient";
            TextBox ingr = new TextBox();
            ingr.Name = "ingr";
            ingr.Height = 70;
            ingr.Width = 280;
            ingredient.Children.Add(ingrTitle);
            ingredient.Children.Add(ingr);

            TextBlock volTitle = new TextBlock();
            volTitle.Foreground = new SolidColorBrush(Colors.Yellow);
            volTitle.Height = 30;
            volTitle.Width = 83;
            volTitle.Text = "Volume";
            TextBox vol = new TextBox();
            vol.Name = "weig";
            vol.Height = 70;
            vol.Width = 98;
            InputScope scope = new InputScope();
            InputScopeName name = new InputScopeName();
            name.NameValue = InputScopeNameValue.Number;
            scope.Names.Add(name);
            vol.InputScope = scope;
            volume.Children.Add(volTitle);
            volume.Children.Add(vol);

            TextBlock mil = new TextBlock();
            mil.Foreground = new SolidColorBrush(Colors.Yellow);
            mil.Height = 36;
            mil.Width = 62;
            mil.Text = "ml";
            mil.FontSize = 25;
            mil.Margin = new Thickness(0, 40, 0, 10);

            nowy.Children.Add(ingredient);
            nowy.Children.Add(volume);
            nowy.Children.Add(mil);

            listIngredients.Add(nowy);
            howMany++;


            return nowy;
        }

        private StackPanel AddDescription()
        {
            StackPanel nowy = new StackPanel();
            nowy.Orientation = System.Windows.Controls.Orientation.Horizontal;
            StackPanel ingredient = new StackPanel();
            StackPanel weight = new StackPanel();
            TextBlock ingrTitle = new TextBlock();
            ingrTitle.Foreground = new SolidColorBrush(Colors.Yellow);
            ingrTitle.Height = 30;
            ingrTitle.Width = 426;
            ingrTitle.Text = "Description";

            desc.Height = 280;
            desc.Width = 456;
            ingredient.Children.Add(ingrTitle);
            ingredient.Children.Add(desc);

            nowy.Children.Add(ingredient);

            return nowy;
        }

        private StackPanel AddName()
        {
            StackPanel nowy = new StackPanel();
            nowy.Orientation = System.Windows.Controls.Orientation.Horizontal;
            StackPanel ingredient = new StackPanel();

            namae.Height = 70;
            namae.Width = 440;

            namae.Margin = new Thickness(-10, 0, 0, 0);
            ingredient.Children.Add(namae);

            nowy.Children.Add(ingredient);

            return nowy;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }


        private void Save_Click(object sender, EventArgs e)
        {

            Drink add = new Drink();
            string name = namae.Text;
            string ingredients = "";
            string weights = "";


            foreach (StackPanel sp in listIngredients)
            {
                TextBox ingr1 = new TextBox();
                TextBox weig1 = new TextBox();
                for (int i = 0; i < sp.Children.Count(); i++)
                {

                    var child = VisualTreeHelper.GetChild(sp, i);
                    if (child is StackPanel)
                    {
                        StackPanel sp2 = (StackPanel)child;
                        for (int ii = 0; ii < sp2.Children.Count(); ii++)
                        {


                            TextBox tmp = new TextBox();
                            var child2 = VisualTreeHelper.GetChild(sp2, ii);
                            if (child2 is TextBox)
                            {

                                tmp = (TextBox)child2;

                                if (tmp.Name.Equals("ingr"))
                                {
                                    ingr1 = tmp;

                                }
                                if (tmp.Name.Equals("weig"))
                                {
                                    weig1 = tmp;

                                }
                            }
                        }

                    }


                }


                if (!(ingr1 == null) && !(weig1 == null))
                {

                    string ingrT = ingr1.Text.Replace("$", " ");
                    string weigT = weig1.Text.Replace("$", " ");
                    if (!(String.IsNullOrWhiteSpace(ingrT)) && !(String.IsNullOrWhiteSpace(weigT)))
                    {
                        ingredients += ingrT + "$";
                        weights += weigT + "$";
                    }
                }

            }

            if (!((String.IsNullOrWhiteSpace(name)) || (String.IsNullOrWhiteSpace(ingredients)) || (String.IsNullOrWhiteSpace(weights))))
            {
                add.DrinkName = name;
                add.DrinkIngredients = ingredients.Substring(0, ingredients.Length - 1);
                add.IngredientsWeight = weights.Substring(0, weights.Length - 1); ;

                string descr = desc.Text;

                if (!String.IsNullOrWhiteSpace(descr))
                {
                    add.DrinkDescription = descr;
                }

                MessageBoxResult result = MessageBox.Show("Are you sure you want to add this Drink ?",
                                                        "Alert",
                                                        MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    DatabaseClass databaseClass = new DatabaseClass();
                    databaseClass.AddDrink(add);
                    NavigationService.Navigate(new Uri("/ListPage.xaml?ing1=" + "_", UriKind.Relative));
         
                }

                  }
            else
            {
                MessageBox.Show("Please give name and one ingredient !");
            }


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
                listbox.Items.Add(AddIngredient()); 
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Add(AddDescription());
            button2.IsEnabled = false;
        }




    }
}