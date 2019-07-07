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
    public partial class PerfectHelp : PhoneApplicationPage
    {
        public PerfectHelp()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string aboutMe = "Perfect number is a positive integer that is equal to the sum of its proper positive divisors, that is, the sum of its positive divisors excluding the number itself. For example,\n\n";

            aboutMe += "6 = 1 + 2 + 3\n\n";

            aboutMe += "Consider number 6, 1, 2, and 3 are its proper positive divisors, and their sum gives back 6 itself.\n";

            aboutMe += "Few other examples of perfect numbers are - 28, 496, 8128 etc.";

            numberTextBlock.Text = aboutMe;


        }
    }
}