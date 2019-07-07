﻿using System;
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
    public partial class PerfectGenerate : PhoneApplicationPage
    {
        GetNumbers numberObj = new GetNumbers();

        public PerfectGenerate()
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
                string gotPerfectNumber = numberObj.generatePerfectNumber(searchTextbox.Text);
                if (gotPerfectNumber.Equals("Invalid number"))
                    numberTextBlock.Text = gotPerfectNumber;


                else if (gotPerfectNumber.Equals("/"))
                    numberTextBlock.Text = "No Perfect Number exists within the given limit";

                else
                {
                    numberTextBlock.Text = "Perfect Numbers are:\n";
                    string[] disp = gotPerfectNumber.Split('/');
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