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
    /// Interaction logic for Attack.xaml
    /// </summary>
    public partial class Attack : Page
    {
        User user;
        public Attack()
        {
            InitializeComponent();
            user = ((MainWindow)Application.Current.MainWindow).getUser();
            if ( 1 <= user.pokemon[user.current].movecount)
            {
                move1.Content = user.pokemon[user.current].moves[0].name;
                power1.Text = "Power: " + user.pokemon[user.current].moves[0].power.ToString();
                pp1.Text = "PP: " + user.pokemon[user.current].moves[0].pp.ToString() + " / " + user.pokemon[user.current].moves[0].maxpp.ToString();
                if (user.pokemon[user.current].moves[0].pp == 0)
                    move1.IsEnabled = false;
            }
            if (2 <= user.pokemon[user.current].movecount)
            {
                move2.Content = user.pokemon[user.current].moves[1].name;
                power2.Text = "Power: " + user.pokemon[user.current].moves[1].power.ToString();
                pp2.Text = "PP: " + user.pokemon[user.current].moves[1].pp.ToString() + " / " + user.pokemon[user.current].moves[1].maxpp.ToString();
                if (user.pokemon[user.current].moves[1].pp == 0)
                    move2.IsEnabled = false;
            }
            if (3 <= user.pokemon[user.current].movecount)
            {
                move3.Content = user.pokemon[user.current].moves[2].name;
                power3.Text = "Power: " + user.pokemon[user.current].moves[2].power.ToString();
                pp3.Text = "PP: " + user.pokemon[user.current].moves[2].pp.ToString() + " / " + user.pokemon[user.current].moves[2].maxpp.ToString();
                if (user.pokemon[user.current].moves[2].pp == 0)
                    move3.IsEnabled = false;
            }
            if (4 <= user.pokemon[user.current].movecount)
            {
                move4.Content = user.pokemon[user.current].moves[3].name;
                power4.Text = "Power: " + user.pokemon[user.current].moves[3].power.ToString();
                pp4.Text = "PP: " + user.pokemon[user.current].moves[3].pp.ToString() + " / " + user.pokemon[user.current].moves[3].maxpp.ToString();
                if (user.pokemon[user.current].moves[3].pp == 0)
                    move4.IsEnabled = false;
            }
        }

        // Move 1
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user.pokemon[user.current].moves[0].pp--;
            ((MainWindow)Application.Current.MainWindow).setUser(user);
            ((MainWindow)Application.Current.MainWindow).setMove(0);
            this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
        }

        // Move 2
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user.pokemon[user.current].moves[1].pp--;
            ((MainWindow)Application.Current.MainWindow).setUser(user);
            ((MainWindow)Application.Current.MainWindow).setMove(1);
            this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
        }

        // Move 3
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (user.pokemon[user.current].moves[2] != null)
            {
                user.pokemon[user.current].moves[2].pp--;
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                ((MainWindow)Application.Current.MainWindow).setMove(2);
                this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
            }

        }

        // Move 4
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(user.pokemon[user.current].moves[3] != null)
            {
                user.pokemon[user.current].moves[3].pp--;
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                ((MainWindow)Application.Current.MainWindow).setMove(3);
                this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
            }
        }
    }
}
