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
using System.Windows.Media.Imaging;


namespace PhoneApp
{
    public partial class ListPage : PhoneApplicationPage
    {
        DatabaseClass databaseClass = new DatabaseClass();
        int selectedDrinkID = -1;
        List<Drink> listOfDrinks;
        string ingredient1;
        string ingredient2;
        string ingredient3;


        public ListPage()
        {
            ingredient1 = string.Empty;
            ingredient2 = string.Empty;
            ingredient3 = string.Empty;
            InitializeComponent();
        }

        private void Find()
        {

        }

        private void ShowDrinks()
        {
            IList<Drink> drinkList = databaseClass.GetDrinksList();
            IEnumerable<Drink> queryListDrinks = drinkList;
            listOfDrinks = queryListDrinks.ToList();

            List<ListBox> Listlistbox = new List<ListBox>();
            Listlistbox.Add(new ListBox());

            List<PivotItem> Listpivotitem = new List<PivotItem>();
            Listpivotitem.Add(new PivotItem());
            Listpivotitem[0].Header = "Drink List             ";
            Listpivotitem[0].Margin = new Thickness(0, 50, 0, 100);

            Listpivotitem[0].Content = Listlistbox[0];
            pivotControl.Items.Add(Listpivotitem[0]);

            int listboxindex = 0;

            for (int i = 0; i < listOfDrinks.Count; i++)
            {
                Uri uri = new Uri("Images/appIcon.png", UriKind.Relative);
                BitmapImage imgSource = new BitmapImage(uri);
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = imgSource;

                Drink evnt = listOfDrinks[i];
                TextBlock textBlockHour = new TextBlock();
                textBlockHour.Text = evnt.DrinkName;
                textBlockHour.Foreground = new SolidColorBrush(Colors.Yellow);
                textBlockHour.FontSize = 25;
                textBlockHour.Margin = new Thickness(0, 10, 0, 0);

                TextBlock textBlockNameAndPlace = new TextBlock();
                textBlockNameAndPlace.Text = evnt.DrinkIngredients.Replace("$", ", ");
                textBlockNameAndPlace.Foreground = new SolidColorBrush(Colors.White);
                textBlockNameAndPlace.FontSize = 22;

                StackPanel stackPanel1 = new StackPanel();
                stackPanel1.Width = 320;
                stackPanel1.Children.Add(textBlockHour);
                stackPanel1.Children.Add(textBlockNameAndPlace);

                Button button = new Button();
                button.Background = imageBrush;
                button.Height = 100;
                button.Width = 100;
                button.BorderThickness = new Thickness(3, 3, 3, 3);
                button.BorderBrush = new SolidColorBrush(Colors.Yellow);
                button.Margin = new Thickness(0, 0, 10, 0);
                button.Name = listOfDrinks[i].DrinkID.ToString();
                button.Click += new RoutedEventHandler(button_Click);

                StackPanel stackPanel2 = new StackPanel();
                stackPanel2.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackPanel2.Children.Add(button);
                stackPanel2.Children.Add(stackPanel1);



                if (ingredient1.Equals("_"))
                {
                    Listlistbox[listboxindex].Items.Add(stackPanel2);
                }
                else
                {
                    if (!(String.IsNullOrEmpty(ingredient1)))
                    {
                        if (!(String.IsNullOrEmpty(ingredient2)))
                        {
                            if (!(String.IsNullOrEmpty(ingredient1)))
                            {
                                if (evnt.DrinkIngredients.Contains(ingredient1) && evnt.DrinkIngredients.Contains(ingredient2) && evnt.DrinkIngredients.Contains(ingredient3))
                                {
                                    Listlistbox[listboxindex].Items.Add(stackPanel2);
                                }
                            }
                            else
                            {
                                if (evnt.DrinkIngredients.Contains(ingredient1) && evnt.DrinkIngredients.Contains(ingredient2))
                                {
                                    Listlistbox[listboxindex].Items.Add(stackPanel2);
                                }
                            }
                        }
                        else
                        {

                            if (evnt.DrinkIngredients.Contains(ingredient1))
                            {
                                Listlistbox[listboxindex].Items.Add(stackPanel2);
                            }
                        }

                    }
                }

            }
        }


        private void AddEvent_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddPage.xaml", UriKind.Relative));
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            if (selectedDrinkID == -1)
            {
                MessageBox.Show("Select an Drink please !");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to edit this Drink ?",
                                                            "Alert",
                                                            MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {

                    NavigationService.Navigate(new Uri("/EditDrinkPage.xaml", UriKind.Relative));
                }
                else
                {
                    Button btn = new Button();
                    btn = (Button)FindName(selectedDrinkID.ToString());
                    btn.Background = new SolidColorBrush(Colors.Red);
                }
            }
        }



        private void Refresh_Click(object sender, EventArgs e)
        {
            int l = pivotControl.Items.Count;
            for (int i = 0; i < l; i++)
            {
                pivotControl.Items.RemoveAt(0);
            }

            ShowDrinks();
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationBar.Mode = Microsoft.Phone.Shell.ApplicationBarMode.Default;
            Button btn = (Button)sender;
            selectedDrinkID = int.Parse(btn.Name.ToString());
            Drink dr = databaseClass.GetDrinkByID(selectedDrinkID);
            NavigationService.Navigate(new Uri("/DrinkPage.xaml?name=" + dr.DrinkName, UriKind.Relative));
        }


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string s = "";

            if (NavigationContext.QueryString.TryGetValue("ing1", out s))
            {
                ingredient1 = s;
            }
            if (NavigationContext.QueryString.TryGetValue("ing2", out s))
            {
                ingredient2 = s;
            }
            if (NavigationContext.QueryString.TryGetValue("ing3", out s))
            {
                ingredient3 = s;
            }


            ShowDrinks();

            var lastPage = NavigationService.BackStack.FirstOrDefault();

            if (lastPage != null && lastPage.Source.ToString() != "/MainPage.xaml")
            {
                NavigationService.RemoveBackEntry();
            }



        }
    }
}