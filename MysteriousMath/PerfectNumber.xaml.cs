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
    public partial class PerfectNumber : PhoneApplicationPage
    {
        public PerfectNumber()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/PerfectGenerate.xaml", UriKind.Relative));
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/PerfectFind.xaml", UriKind.Relative));
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/PerfectHelp.xaml", UriKind.Relative));
        }
    }
}