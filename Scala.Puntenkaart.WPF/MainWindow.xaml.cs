using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prb.Puntenkaart.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void cmbScience_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbScience.IsLoaded)
            {
            }
        }

        private void cmbMath_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbMath.IsLoaded)
            {
            }
        }

        private void cmbLanguages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbLanguages.IsLoaded)
            {
            }
        }
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
        }


        private void txtScience_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtScience.IsLoaded)
            {
            }
        }

        private void txtScience_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtMath_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtMath.IsLoaded)
            {
            }
        }

        private void txtMath_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtLanguages_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtLanguages.IsLoaded)
            {
            }
        }

        private void txtLanguages_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
