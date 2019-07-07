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
    public partial class KaprekarHelp : PhoneApplicationPage
    {
        public KaprekarHelp()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string aboutMe = "Kaprekar number for a given base is a non-negative integer, the representation of whose square in that base can be split into two parts that add up to the original number again. For instance, 45 is a Kaprekar number,\n\n";

            aboutMe += "45² = 2025\n\n";

            aboutMe += "20 + 25 = 45\n\n";

            aboutMe += "Few other examples of Kaprekar numbers are - 297, 703, 999 , 2223 etc.";

            numberTextBlock.Text = aboutMe;
        }
    }
}