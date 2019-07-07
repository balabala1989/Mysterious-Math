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

namespace MysteriousMath
{
    public partial class AmicableFind : PhoneApplicationPage
    {

        GetNumbers numberObj = new GetNumbers();
        public AmicableFind()
        {
            InitializeComponent();
        }

        private void searchTextbox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            searchTextbox.Text = "";
            numberTextBlock.Text = "Please Enter a number";
        }

        private void seaTextbox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            seaTextbox.Text = "";
            numberTextBlock.Text = "Please Enter a number";
        }

        private void seaTextbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchTextbox.Text.Equals("Tap here to Enter a number"))
            {
                numberTextBlock.Text = "Please Enter a number";
            }

            else
            {
                numberTextBlock.Text = numberObj.findAmicableNumberPair(searchTextbox.Text,seaTextbox.Text);

            }
        }
    }
}