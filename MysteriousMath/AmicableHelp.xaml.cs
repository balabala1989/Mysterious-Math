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
    public partial class AmicableHelp : PhoneApplicationPage
    {
        public AmicableHelp()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string aboutMe = "Amicable numbers are a pair of numbers such that the sum of their proper divisors (not including itself) equals the other number. For instance, 220 and 284 are amicable number pair,\n";

            aboutMe += "Divisors of 220\n";

            aboutMe += "1 + 2 + 4 + 5 + 10 + 11 + 20 + 22 + 44 + 55 + 110 = 284\n\n";

            aboutMe += "Divisors of 284\n";

            aboutMe += "1 + 2 + 4 + 71 + 142 = 220\n\n";

            aboutMe += "Few other examples are - 1184 and 1210, 2620 and 2924, 5020 and 5564 etc.";

            numberTextBlock.Text = aboutMe;
        }
    }
}