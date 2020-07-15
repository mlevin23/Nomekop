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
    /// Interaction logic for Choose.xaml
    /// </summary>
    public partial class Choose : Page
    {
        public Choose()
        {
            InitializeComponent();
        }

        //Squirtle
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = ((MainWindow)Application.Current.MainWindow).getUser();
            user.pokemon[0] = new Squirtle(5);
            user.pokecount = 1;
            ((MainWindow)Application.Current.MainWindow).setUser(user);
            this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));

        }

        //Charmander
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User user = ((MainWindow)Application.Current.MainWindow).getUser();
            user.pokemon[0] = new Charmander(5);
            user.pokecount = 1;
            ((MainWindow)Application.Current.MainWindow).setUser(user);
            this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
        }

        //Bulbasaur
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            User user = ((MainWindow)Application.Current.MainWindow).getUser();
            user.pokemon[0] = new Bulbasaur(5);
            user.pokecount = 1;
            ((MainWindow)Application.Current.MainWindow).setUser(user);
            this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
        }
    }
}
