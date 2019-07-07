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
    public partial class About : PhoneApplicationPage
    {
        

        public About()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string aboutMe = "\"Mysterious Math\" allows you to generate and check some of the mysterious numbers in Mathematics. You can generate and check for \n";

            aboutMe += "1. Armstrong Number\n2. Perfect Number\n3. Kaprekar Number\n4. Ramanujam Number\n5. Amicable Numbers\n\n";

            aboutMe += "If you dont know what these numbers are you can go through \"Help\" provide under each number.\n\n Have fun!!!!";

            aboutTextBlock.Text = aboutMe;
        }
    }
}