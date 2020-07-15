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
    /// Interaction logic for Swap.xaml
    /// </summary>
    public partial class Swap : Page
    {
        User user;
        public Swap()
        {
            InitializeComponent();
            user = ((MainWindow)Application.Current.MainWindow).getUser();
            if (1 <= user.pokecount)
            {
                poke1.Content = user.pokemon[0].name;
                poke1hp.Text = user.pokemon[0].health + " / " + user.pokemon[0].maxhealth;
                poke1i.Source = user.pokemon[0].bitmap;
                poke1lvl.Text = "Lv. " + user.pokemon[0].level.ToString();
            }
            if (2 <= user.pokecount)
            {
                poke2.Content = user.pokemon[1].name;
                poke2hp.Text = user.pokemon[1].health + " / " + user.pokemon[1].maxhealth;
                poke2i.Source = user.pokemon[1].bitmap;
                poke2lvl.Text = "Lv. " + user.pokemon[1].level.ToString();
            }
            if (3 <= user.pokecount)
            {
                poke3.Content = user.pokemon[2].name;
                poke3hp.Text = user.pokemon[2].health + " / " + user.pokemon[2].maxhealth;
                poke3i.Source = user.pokemon[2].bitmap;
                poke3lvl.Text = "Lv. " + user.pokemon[2].level.ToString();
            }
            if (4 <= user.pokecount)
            {
                poke4.Content = user.pokemon[3].name;
                poke4hp.Text = user.pokemon[3].health + " / " + user.pokemon[3].maxhealth;
                poke4i.Source = user.pokemon[3].bitmap;
                poke4lvl.Text = "Lv. " + user.pokemon[3].level.ToString();
            }
            if (5 <= user.pokecount)
            {
                poke5.Content = user.pokemon[4].name;
                poke5hp.Text = user.pokemon[4].health + " / " + user.pokemon[4].maxhealth;
                poke5i.Source = user.pokemon[4].bitmap;
                poke5lvl.Text = "Lv. " + user.pokemon[4].level.ToString();
            }
            if (6 <= user.pokecount)
            {
                poke6.Content = user.pokemon[5].name;
                poke6hp.Text = user.pokemon[5].health + " / " + user.pokemon[5].maxhealth;
                poke6i.Source = user.pokemon[5].bitmap;
                poke6lvl.Text = "Lv. " + user.pokemon[5].level.ToString();
            }
        }


        private void poke1_Click(object sender, RoutedEventArgs e)
        {
            user.current = 0;
            ((MainWindow)Application.Current.MainWindow).setUser(user);
            this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
        }

        private void poke2_Click(object sender, RoutedEventArgs e)
        {
            if (2 <= user.pokecount)
            {
                user.current = 1;
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
            }

        }

        private void poke3_Click(object sender, RoutedEventArgs e)
        {
            if (3 <= user.pokecount)
            {
                user.current = 2;
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
            }
        }

        private void poke4_Click(object sender, RoutedEventArgs e)
        {
            if (4 <= user.pokecount)
            {
                user.current = 3;
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
            }
        }

        private void poke5_Click(object sender, RoutedEventArgs e)
        {
            if (5 <= user.pokecount)
            {
                user.current = 4;
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
            }
        }

        private void poke6_Click(object sender, RoutedEventArgs e)
        {
            if (6 <= user.pokecount)
            {
                user.current = 5;
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                this.NavigationService.Navigate(new Uri("Battle.xaml", UriKind.Relative));
            }
        }
    }
}
