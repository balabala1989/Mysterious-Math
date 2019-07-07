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
    public partial class ArmstrongHelp : PhoneApplicationPage
    {
        public ArmstrongHelp()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string aboutMe = "Armstrong numbers are the sum of their own digits to the power of the number of digits. For example,\n\n";

            aboutMe += "153 = 1³ + 5³ + 3³\n\n";

            aboutMe += "Each digit is raised to the power three because 153 has three digits. They are totalled and we get the original number again! Notice that Armstrong numbers are base dependent, but we'll mainly be dealing with base-10\n";

            aboutMe += "Few other Armstrong numbers - 1, 370, 371 etc.";

            numberTextBlock.Text = aboutMe;
        }
    }
}