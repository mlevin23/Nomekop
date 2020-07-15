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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        User user;
        int battletype = 0; // 1 wild, 2 trainer, 3 elite
        int movechosen = -1;
        User enemy;
        Pokemon wild;
        bool done = true;
        bool attacked = false;
        bool userdead = false;
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new TitlePage();
        }


        public void setDead(bool fi)
        {
            userdead = fi;
        }

        public void setAttacked(bool at)
        {
            attacked = at;
        }

        public void setWild(Pokemon poke)
        {
            wild = poke;
        }

        public void setEnemy(User en)
        {
            enemy = en;
        }

        public void setUser(User input)
        {
            user = input;
        }

        public void setBattleType(int input)
        {
            battletype = input;
        }

        public void setMove(int input)
        {
            movechosen = input;
        }

        public void setDone(bool dn)
        {
            done = dn;
        }

        public bool getDead()
        {
            return userdead;
        }
        public bool getDone()
        {
            return done;
        }

        public bool getAttacked()
        {
            return attacked;
        }

        public Pokemon getWild()
        {
            return wild;
        }

        public User getEnemy()
        {
            return enemy;
        }

        public int getMove()
        {
            return movechosen;
        }

        public User getUser()
        {
            return user;
        }

        public int getBattleType()
        {
            return battletype;
        }
    }
}
