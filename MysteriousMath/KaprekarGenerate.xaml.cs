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
    public partial class KaprekarGenerate : PhoneApplicationPage
    {
        GetNumbers numberObj = new GetNumbers();
        public KaprekarGenerate()
        {
            InitializeComponent();
        }

        private void searchTextbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchTextbox.Text.Equals("Tap here to Enter a number"))
            {
                numberTextBlock.Text = "Please Enter a number";
            }

            else
            {
                string gotKaprekarNumber = numberObj.generateKaprekarNumber(searchTextbox.Text);
                if (gotKaprekarNumber.Equals("Invalid number"))
                    numberTextBlock.Text = gotKaprekarNumber;


                else if (gotKaprekarNumber.Equals("/"))
                    numberTextBlock.Text = "No Kaprekar Number exists within the given limit";

                else
                {
                    numberTextBlock.Text = "Kaprekar Numbers are:\n";
                    string[] disp = gotKaprekarNumber.Split('/');
                    for (int i = 1; i < disp.Length; i++)
                        numberTextBlock.Text += disp[i] + "\n";
                }
            }
        }

        private void searchTextbox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            searchTextbox.Text = "";
            numberTextBlock.Text = "Please Enter a number";
        }
    }
}