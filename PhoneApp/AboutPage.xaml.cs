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
    public partial class AboutPage : PhoneApplicationPage
    {
        

        public AboutPage()
        {
            InitializeComponent();
            show();
            //this.Details.Text = "Welcome to ALCO3!\nALCO3 is an app which helps you to find awesome non-alcoholic drinks!\n"
              //                  + " \n \n";
        }

        private void show() 
        {
            ListBox listbox = new ListBox();
            string[] optionList = {"Pick from the list", "Mix your favourite ingredients", "Add your own recipe" };
            string[] extra = { "List of various non-alcoholic\ndrinks available!", "Choose ingredients,\nshake your phone and explore!", "List is missing a drink you like?\nAdd it!" };
            Color[] colorList = { Colors.Green, Colors.Cyan, Colors.Orange };


            for (int i = 0; i < optionList.Length; i++)
            {
                TextBlock textOption = new TextBlock();
                textOption.Text = optionList[i];
                textOption.Foreground = new SolidColorBrush(Colors.Yellow);
                textOption.FontSize = 25;
                textOption.Margin = new Thickness(0, 15, 0, 0);

                TextBlock textExtra = new TextBlock();
                textExtra.Text = extra[i];
                textExtra.Foreground = new SolidColorBrush(Colors.White);
                textExtra.FontSize = 23;
                
                StackPanel stackPanel1 = new StackPanel();
                stackPanel1.Width = 320;
                stackPanel1.Children.Add(textOption);
                stackPanel1.Children.Add(textExtra);

                Button button = new Button();
                button.Background = new SolidColorBrush(Colors.Yellow);
                button.Height = 120;
                button.Width = 30;
                button.BorderThickness = new Thickness(0, 0, 0, 0);
                button.Margin = new Thickness(0, 10, 10, 0);
                button.Name = i.ToString();

                StackPanel stackPanel2 = new StackPanel();
                stackPanel2.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackPanel2.Children.Add(button);
                stackPanel2.Children.Add(stackPanel1);
               
                listbox.Items.Add(stackPanel2);
            }
            ContentPanel.Children.Add(listbox);
        }
    }
}