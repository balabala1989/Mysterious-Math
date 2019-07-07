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
    public partial class Index : PhoneApplicationPage
    {
        public Index()
        {
            InitializeComponent();
        }

        private void armstrongNumberButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/ArmstrongNumber.xaml", UriKind.Relative));
        }

        private void perfectNumberButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/PerfectNumber.xaml", UriKind.Relative));
        }

        private void kaprekarNumberButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/KaprekarNumber.xaml", UriKind.Relative));
        }

        private void ramanujamNumberButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RamanujamNumber.xaml", UriKind.Relative));
        }

        private void amicableNumberButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/AmicableNumber.xaml", UriKind.Relative));
        }
    }
}