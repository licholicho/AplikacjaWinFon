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
            ListBox listbox = new ListBox();

            List<PivotItem> Listpivotitem = new List<PivotItem>();
            Listpivotitem.Add(new PivotItem());

            Listpivotitem[0].Header = _currentDrink.DrinkName;

            Listpivotitem[0].Content = listbox;

            pivotControl.Items.Add(Listpivotitem[0]);

            TextBlock tbTitle = new TextBlock();
            tbTitle.Text = "Ingredients";
            tbTitle.FontSize = 40;
            tbTitle.Foreground = new SolidColorBrush(Colors.Yellow);
            tbTitle.Margin = new Thickness(10, 0, 0, 10);
            listbox.Items.Add(tbTitle);

            string[] ingr = _currentDrink.DrinkIngredients.Split('$');
            string[] weig = _currentDrink.IngredientsWeight.Split('$');
            string outeri = string.Empty;
            string outerw = string.Empty;
            for (int i = 0; i < ingr.Count(); i++)
            {
                outerw = weig[i] + " ml  ";
                outeri = ingr[i];
                TextBlock tbi = new TextBlock();
                tbi.TextWrapping = TextWrapping.Wrap;
                tbi.Text = outeri;

                TextBlock tbw = new TextBlock();
                tbw.TextWrapping = TextWrapping.Wrap;
                tbw.Width = 75;
                tbw.Text = outerw;
                tbw.Margin = new Thickness(10, 0, 5, 1);

                StackPanel stackPanel1 = new StackPanel();
                stackPanel1.Width = 320;
                stackPanel1.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackPanel1.Children.Add(tbw);
                stackPanel1.Children.Add(tbi);
                listbox.Items.Add(stackPanel1);
            }

            TextBlock tbTitle1 = new TextBlock();
            tbTitle1.Margin = new Thickness(10, 25, 0, 10);
            tbTitle1.Text = "Description";
            tbTitle1.FontSize = 40;
            tbTitle1.Foreground = new SolidColorBrush(Colors.Yellow);

            TextBlock tb1 = new TextBlock();
            tb1.Width = 420;
            tb1.Margin = new Thickness(10, 5, 20, 0);
            tb1.TextWrapping = TextWrapping.Wrap;
            if (String.IsNullOrEmpty(_currentDrink.DrinkDescription))
            {
                _currentDrink.DrinkDescription = "...";
            }
            tb1.Text = _currentDrink.DrinkDescription;
            listbox.Items.Add(tbTitle1);
            listbox.Items.Add(tb1);

        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this Drink ?",
                                                        "Alert",
                                                        MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                DatabaseClass databaseClass = new DatabaseClass();
                if (databaseClass.DeleteDrink(_currentDrink.DrinkID))
                {
                    MessageBox.Show("Drink deleted successfully!");
                    NavigationService.Navigate(new Uri("/ListPage.xaml?ing1=" + "_", UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("There were an error when trying to delete!");
                }
            }

        }

        public string DisplayIngredients { get; set; }

        public string DisplayDescription { get; set; }

    }
}