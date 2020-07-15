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

namespace Nomekop
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Page
    {
        public MainScreen()
        {
            InitializeComponent();
        }


        // Wild battle
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           ((MainWindow)Application.Current.MainWindow).setBattleType(1);
            this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
        }

        // Trainer battle
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).setBattleType(2);
            this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
        }

        //Elite 3
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).setBattleType(3);
            this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).setBattleType(4);
            this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
        }
    }
}
