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
    public partial class ListPage : PhoneApplicationPage
    {
        DatabaseClass databaseClass = new DatabaseClass();
        int selectedDrinkID = -1;
        List<Drink> eventsListPerDay;
        String ingredient1 = "ogórek";
        String ingredient2 = "";
        String ingredient3 = "";


        public ListPage()
        {
            InitializeComponent();
            // init();
            ShowEvents();
        }

        private void ShowEvents()
        {
            IList<Drink> drinkList = databaseClass.GetDrinksList();

            //eventsListPerDay = TransformToEventsListPerDay(eventsList);
            IEnumerable<Drink> queryListDrinks = drinkList;//.OrderBy(evt => evt.DrinkName);
            eventsListPerDay = queryListDrinks.ToList();

            //          String name = "woda";


            //create panoramaItem and the ListBox
            List<ListBox> Listlistbox = new List<ListBox>();
            Listlistbox.Add(new ListBox());

            List<PivotItem> Listpivotitem = new List<PivotItem>();
            Listpivotitem.Add(new PivotItem());
            Listpivotitem[0].Header = "Drinks";

            Listpivotitem[0].Content = Listlistbox[0];
            pivotControl.Items.Add(Listpivotitem[0]);

            int listboxindex = 0;

            for (int i = 0; i < eventsListPerDay.Count; i++)// Drink evnt in eventsListPerDay)
            {
                //look for events of today from EventsList
                Drink evnt = eventsListPerDay[i];
                System.Diagnostics.Debug.WriteLine("dlu: " + eventsListPerDay.Count + " " + evnt.DrinkName + " " + evnt.DrinkID);
                TextBlock textBlockHour = new TextBlock();
                textBlockHour.Text = evnt.DrinkName;
                textBlockHour.Foreground = new SolidColorBrush(Colors.Magenta);
                textBlockHour.FontSize = 20;

                TextBlock textBlockNameAndPlace = new TextBlock();
                textBlockNameAndPlace.Text = evnt.DrinkIngredients;
                textBlockNameAndPlace.Foreground = new SolidColorBrush(Colors.White);
                textBlockNameAndPlace.FontSize = 20;

                StackPanel stackPanel1 = new StackPanel();
                stackPanel1.Width = 311;
                stackPanel1.Children.Add(textBlockHour);
                stackPanel1.Children.Add(textBlockNameAndPlace);

                Button button = new Button();
                button.Background = new SolidColorBrush(Colors.Orange);
                button.Height = 100;
                button.Width = 90;
                button.BorderThickness = new Thickness(0, 0, 0, 0);
                button.Margin = new Thickness(0, 0, 9, 0);
                button.Name = eventsListPerDay[i].DrinkID.ToString();
                button.Click += new RoutedEventHandler(button_Click);

                StackPanel stackPanel2 = new StackPanel();
                stackPanel2.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackPanel2.Children.Add(button);
                stackPanel2.Children.Add(stackPanel1);

                System.Diagnostics.Debug.WriteLine(evnt.DrinkName);

                if (!ingredient1.Equals(""))
                {
                    if (!ingredient2.Equals(""))
                    {
                        if (!ingredient3.Equals(""))
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
                /*  else
                  {
                      listboxindex++;
                      name = eventsListPerDay[i].DrinkName;
                      i--;

                      Listpivotitem.Add(new PivotItem());
                      Listpivotitem[listboxindex].Header = "Drinksss";
                      Listlistbox.Add(new ListBox());
                      Listpivotitem[listboxindex].Content = Listlistbox[listboxindex];

                      pivotControl.Items.Add(Listpivotitem[listboxindex]);
                  }*/
            }
        }


        private void AddEvent_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddDrinkPage.xaml", UriKind.Relative));
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            if (selectedDrinkID == -1)//no item selected
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
                    //when cancel, unselect the selected button
                    Button btn = new Button();
                    btn = (Button)FindName(selectedDrinkID.ToString());
                    btn.Background = new SolidColorBrush(Colors.Red);
                }
            }
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {

            if (selectedDrinkID == -1)//no item selected
            {
                MessageBox.Show("Select an Drink please !");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this Drink ?",
                                                            "Alert",
                                                            MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {

                    if (databaseClass.DeleteDrink(selectedDrinkID))
                    {
                        MessageBox.Show("Drink deleted successfully!");
                        Refresh_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("There were an error when trying to delete!");
                    }
                }
                else
                {
                    //when cancel, unselect the selected button
                    Button btn = new Button();
                    btn = (Button)FindName(selectedDrinkID.ToString());
                    btn.Background = new SolidColorBrush(Colors.Red);
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            // clear the UI
            int l = pivotControl.Items.Count;
            for (int i = 0; i < l; i++)
            {
                pivotControl.Items.RemoveAt(0);
            }

            //show the events
            ShowEvents();
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationBar.Mode = Microsoft.Phone.Shell.ApplicationBarMode.Default;
            Button btn = (Button)sender;
            btn.Background = new SolidColorBrush(Colors.Yellow);
            selectedDrinkID = int.Parse(btn.Name.ToString());
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            /*   if (e.Content is EditDrinkPage)
               {
                   //get the Drink with the specified ID
                   Drink vnt = new Drink();
                   foreach(Drink ev in eventsListPerDay)
                   {
                       if (ev.DrinkID == selectedDrinkID)
                       {
                           vnt = ev;
                           break;
                       }
                   }

                   //pass the Drink to the EditDrinkPage
               TODO     (e.Content as EditDrinkPage).evntToEdit = vnt;
               }*/
            if (e.Content is FindPage)
            {
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
            }

        }
    }
}