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
    public partial class RamanujamHelp : PhoneApplicationPage
    {
        public RamanujamHelp()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string aboutMe = "Ramanujam number is the number that can be expressed as the sum of two cubes in two different ways. For instance,\n\n";

            aboutMe += "1729 = 1³ + 12³ = 9³ + 10³\n\n";

            aboutMe += "Few other examples of Ramanujam numbers are - 4104, 13832, 20683 etc.";

            numberTextBlock.Text = aboutMe;
        }
    }
}