using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
    /// Interaction logic for Battle.xaml
    /// </summary>
    public partial class Battle : Page
    {

        User user;
        User enemy;
        Pokemon wild;
        Uri uri;
        BitmapImage bitmap;
        Random rand;
        Random rand2;
        int j;
        int highestlvl;
        int pokechoice;
        float percenthp;
        int enchoice;
        public Battle()
        {
            InitializeComponent();
            highestlvl = 0;
            user = ((MainWindow)Application.Current.MainWindow).getUser();
            wild = ((MainWindow)Application.Current.MainWindow).getWild();
            enemy = ((MainWindow)Application.Current.MainWindow).getEnemy();
            pokechoice = user.current;
            if (enemy != null)
                enchoice = enemy.current;
            poke1.Source = user.pokemon[pokechoice].bitmap;
            uri = new Uri("pack://application:,,,/Resources/pokeball.jpg");
            rand = new Random();
            rand2 = new Random();
            bitmap = new BitmapImage(uri);
            status.Text = "What will " + user.pokemon[pokechoice].name + " do?";
            ihp.Text = user.pokemon[pokechoice].health.ToString() + " / " + user.pokemon[pokechoice].maxhealth.ToString();
            ilvl.Text = "Lv. " + user.pokemon[pokechoice].level.ToString() + "\t Exp: " + user.pokemon[pokechoice].exp.ToString() + " / 100";
            if (1 <= user.pokecount)
                iball1.Source = bitmap;
            if (2 <= user.pokecount)
                iball2.Source = bitmap;
            if (3 <= user.pokecount)
                iball3.Source = bitmap;
            if (4 <= user.pokecount)
                iball4.Source = bitmap;
            if (5 <= user.pokecount)
                iball5.Source = bitmap;
            if (6 <= user.pokecount)
                iball6.Source = bitmap;



            if (((MainWindow)Application.Current.MainWindow).getMove() != -1 && ((MainWindow)Application.Current.MainWindow).getAttacked() == false)
            {
                Attack(((MainWindow)Application.Current.MainWindow).getMove());
                ((MainWindow)Application.Current.MainWindow).setAttacked(true);
            }


            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 1)
            {
                ball1.Source = bitmap;
                j = rand.Next(3);
                for (int i = 0; i < user.pokecount; i++)
                {
                    if (highestlvl < user.pokemon[i].level)
                        highestlvl = user.pokemon[i].level;
                }
                if (((MainWindow)Application.Current.MainWindow).getDone())
                {
                    wild = generatePokemon();
                    ((MainWindow)Application.Current.MainWindow).setDone(false);
                }
                poke2.Source = wild.bitmap;
                if (wild.health <= 0)
                {
                    ehp.Text = "0 / " + wild.maxhealth.ToString();
                }
                else
                {
                    ehp.Text = wild.health.ToString() + " / " + wild.maxhealth.ToString();
                }
            }
            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 4)
            {
                if (((MainWindow)Application.Current.MainWindow).getDone())
                {
                    wild = new Grandmamon(100);
                    ((MainWindow)Application.Current.MainWindow).setDone(false);
                }
                ball1.Source = bitmap;
                poke2.Source = wild.bitmap;
                if (wild.health <= 0)
                {
                    ehp.Text = "0 / " + wild.maxhealth.ToString();
                }
                else
                {
                    ehp.Text = wild.health.ToString() + " / " + wild.maxhealth.ToString();
                }
            }
            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 2)
            {

                if (((MainWindow)Application.Current.MainWindow).getDone())
                {
                    enemy = new User(user.rival, "Empty");
                    enemy.pokecount = rand.Next(1, 7);
                    for (int i = 0; i < user.pokecount; i++)
                    {
                        if (highestlvl < user.pokemon[i].level)
                            highestlvl = user.pokemon[i].level;
                    }

                    for (int i = 0; i < enemy.pokecount; i++)
                    {
                        enemy.pokemon[i] = generatePokemon();
                    }
                    enemy.current = enemy.pokecount - 1;
                    enchoice = enemy.pokecount - 1;
                    ((MainWindow)Application.Current.MainWindow).setDone(false);
                }
                if (1 <= enchoice + 1)
                    ball1.Source = bitmap;
                if (2 <= enchoice + 1)
                    ball2.Source = bitmap;
                if (3 <= enchoice + 1)
                    ball3.Source = bitmap;
                if (4 <= enchoice + 1)
                    ball4.Source = bitmap;
                if (5 <= enchoice + 1)
                    ball5.Source = bitmap;
                if (6 <= enchoice + 1)
                    ball6.Source = bitmap;

                if (enchoice >= 0)
                {
                    poke2.Source = enemy.pokemon[enchoice].bitmap;
                    ehp.Text = enemy.pokemon[enchoice].health.ToString() + " / " + enemy.pokemon[enchoice].maxhealth.ToString();
                }

            }
            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 3)
            {
                if (((MainWindow)Application.Current.MainWindow).getDone())
                {
                    enemy = new User(user.rival, "Empty");
                    highestlvl = 50;
                    enemy.pokecount = 6;
                    for (int i = 0; i < enemy.pokecount; i++)
                    {
                        enemy.pokemon[i] = generatePokemon();
                    }
                    enemy.current = enemy.pokecount - 1;
                    enchoice = enemy.pokecount - 1;
                    ((MainWindow)Application.Current.MainWindow).setDone(false);
                }
                if (1 <= enchoice + 1)
                    ball1.Source = bitmap;
                if (2 <= enchoice + 1)
                    ball2.Source = bitmap;
                if (3 <= enchoice + 1)
                    ball3.Source = bitmap;
                if (4 <= enchoice + 1)
                    ball4.Source = bitmap;
                if (5 <= enchoice + 1)
                    ball5.Source = bitmap;
                if (6 <= enchoice + 1)
                    ball6.Source = bitmap;

                if (enchoice >= 0)
                {
                    poke2.Source = enemy.pokemon[enchoice].bitmap;
                    ehp.Text = enemy.pokemon[enchoice].health.ToString() + " / " + enemy.pokemon[enchoice].maxhealth.ToString();
                }

            }
            if ((wild != null && wild.health <= 0) || enchoice == -1)
            {
                choice1.Content = "Finished";
                choice2.Content = "Finished";
                choice3.Content = "Finished";
                choice4.Content = "Finished";
            }

        }

        // Attack
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((wild != null && wild.health <= 0) || enchoice == -1 || ((MainWindow)Application.Current.MainWindow).getDead())
            {
                user.current = 0;
                if (wild != null)
                    wild.health = 1;
                for (int i = 0; i < user.pokecount; i++)
                {
                    user.pokemon[i].health = user.pokemon[i].maxhealth;
                    for (j = 0; j < user.pokemon[i].movecount; j++)
                    {
                        user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                    }
                }
                ((MainWindow)Application.Current.MainWindow).setDead(false);
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                ((MainWindow)Application.Current.MainWindow).setDone(true);
                this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
            }
            else
            {
                eAttack();
                if ((wild != null && wild.health <= 0) || enchoice == -1 || ((MainWindow)Application.Current.MainWindow).getDead())
                {
                    user.current = 0;
                    if (wild != null)
                        wild.health = 1;
                    for (int i = 0; i < user.pokecount; i++)
                    {
                        user.pokemon[i].health = user.pokemon[i].maxhealth;
                        for (j = 0; j < user.pokemon[i].movecount; j++)
                        {
                            user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                        }
                    }
                    ((MainWindow)Application.Current.MainWindow).setDead(false);
                    ((MainWindow)Application.Current.MainWindow).setUser(user);
                    ((MainWindow)Application.Current.MainWindow).setDone(true);
                    this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
                }
                else
                {
                    ((MainWindow)Application.Current.MainWindow).setUser(user);
                    ((MainWindow)Application.Current.MainWindow).setWild(wild);
                    ((MainWindow)Application.Current.MainWindow).setEnemy(enemy);
                    ((MainWindow)Application.Current.MainWindow).setAttacked(false);
                    this.NavigationService.Navigate(new Uri("Attack.xaml", UriKind.Relative));
                }
            }
        }

        // Swap Pokemon
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((wild != null && wild.health <= 0) || enchoice == -1 || ((MainWindow)Application.Current.MainWindow).getDead())
            {
                user.current = 0;
                if (wild != null)
                    wild.health = 1;
                enchoice = 0;
                for (int i = 0; i < user.pokecount; i++)
                {
                    user.pokemon[i].health = user.pokemon[i].maxhealth;
                    for (j = 0; j < user.pokemon[i].movecount; j++)
                    {
                        user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                    }
                }
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                ((MainWindow)Application.Current.MainWindow).setDead(false);
                ((MainWindow)Application.Current.MainWindow).setDone(true);
                this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
            }
            else
            {
                eAttack();
                if ((wild != null && wild.health <= 0) || enchoice == -1 || ((MainWindow)Application.Current.MainWindow).getDead())
                {
                    user.current = 0;
                    if (wild != null)
                        wild.health = 1;
                    enchoice = 0;
                    for (int i = 0; i < user.pokecount; i++)
                    {
                        user.pokemon[i].health = user.pokemon[i].maxhealth;
                        for (j = 0; j < user.pokemon[i].movecount; j++)
                        {
                            user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                        }
                    }
                    ((MainWindow)Application.Current.MainWindow).setUser(user);
                    ((MainWindow)Application.Current.MainWindow).setDead(false);
                    ((MainWindow)Application.Current.MainWindow).setDone(true);
                    this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
                }
                else
                {
                    ((MainWindow)Application.Current.MainWindow).setUser(user);
                    ((MainWindow)Application.Current.MainWindow).setWild(wild);
                    ((MainWindow)Application.Current.MainWindow).setEnemy(enemy);
                    this.NavigationService.Navigate(new Uri("Swap.xaml", UriKind.Relative));
                }
            }
        }

        // Throw pokeball
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if ((wild != null && wild.health <= 0) || enchoice == -1 || ((MainWindow)Application.Current.MainWindow).getDead())
            {
                user.current = 0;
                if (wild != null)
                    wild.health = 1;
                enchoice = 0;
                for (int i = 0; i < user.pokecount; i++)
                {
                    user.pokemon[i].health = user.pokemon[i].maxhealth;
                    for (j = 0; j < user.pokemon[i].movecount; j++)
                    {
                        user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                    }
                }
                ((MainWindow)Application.Current.MainWindow).setUser(user);
                ((MainWindow)Application.Current.MainWindow).setDone(true);
                ((MainWindow)Application.Current.MainWindow).setDead(false);
                this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
            }
            else
            {
                eAttack();
                if ((wild != null && wild.health <= 0) || enchoice == -1 || ((MainWindow)Application.Current.MainWindow).getDead())
                {
                    user.current = 0;
                    if (wild != null)
                        wild.health = 1;
                    enchoice = 0;
                    for (int i = 0; i < user.pokecount; i++)
                    {
                        user.pokemon[i].health = user.pokemon[i].maxhealth;
                        for (j = 0; j < user.pokemon[i].movecount; j++)
                        {
                            user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                        }
                    }
                    ((MainWindow)Application.Current.MainWindow).setUser(user);
                    ((MainWindow)Application.Current.MainWindow).setDone(true);
                    ((MainWindow)Application.Current.MainWindow).setDead(false);
                    this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
                }
                else
                {
                    if (((MainWindow)Application.Current.MainWindow).getBattleType() != 1)
                    {
                        status.Text = "This is not a wild pokemon, you can't capture it!";
                    }
                    else
                    {
                        if (user.pokecount < 6)
                        {
                            percenthp = wild.health / wild.maxhealth;
                            if (percenthp < .2)
                            {
                                MessageBox.Show("You captured " + wild.name);
                                user.pokemon[user.pokecount] = wild.ShallowCopy();
                                user.pokecount++;
                                for (int i = 0; i < user.pokecount; i++)
                                {
                                    user.pokemon[i].health = user.pokemon[i].maxhealth;
                                    for (j = 0; j < user.pokemon[i].movecount; j++)
                                    {
                                        user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                                    }
                                }
                                ((MainWindow)Application.Current.MainWindow).setUser(user);
                                ((MainWindow)Application.Current.MainWindow).setWild(wild);
                                ((MainWindow)Application.Current.MainWindow).setEnemy(enemy);
                                ((MainWindow)Application.Current.MainWindow).setDone(true);
                                this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
                            }
                            else
                            {
                                if (rand.Next(1, 101) * percenthp < 20)
                                {
                                    MessageBox.Show("You captured " + wild.name);
                                    user.pokemon[user.pokecount] = wild.ShallowCopy();
                                    user.pokecount++;
                                    user.current = 0;
                                    for (int i = 0; i < user.pokecount; i++)
                                    {
                                        user.pokemon[i].health = user.pokemon[i].maxhealth;
                                        for (j = 0; j < user.pokemon[i].movecount; j++)
                                        {
                                            user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                                        }
                                    }
                                    ((MainWindow)Application.Current.MainWindow).setUser(user);
                                    ((MainWindow)Application.Current.MainWindow).setWild(wild);
                                    ((MainWindow)Application.Current.MainWindow).setEnemy(enemy);
                                    ((MainWindow)Application.Current.MainWindow).setDone(true);
                                    this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
                                }
                                else
                                    status.Text = "Oh no! " + wild.name + " managed to escape the pokeball! ";
                            }
                        }
                        else
                            MessageBox.Show("You already have 6 pokemon!");
                    }
                }
                
            }
        }

        // Run
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < user.pokecount; i++)
            {
                user.pokemon[i].health = user.pokemon[i].maxhealth;
                for (j = 0; j < user.pokemon[i].movecount; j++)
                {
                    user.pokemon[i].moves[j].pp = user.pokemon[i].moves[j].maxpp;
                }
            }
            user.current = 0;
            if (wild != null)
                wild.health = 1;
            enchoice = 0;
            ((MainWindow)Application.Current.MainWindow).setDead(false);
            ((MainWindow)Application.Current.MainWindow).setUser(user);
            ((MainWindow)Application.Current.MainWindow).setDone(true);
            this.NavigationService.Navigate(new Uri("MainScreen.xaml", UriKind.Relative));
        }

        public Pokemon generatePokemon()
        {
            Pokemon pokemon;
            j = rand.Next(0,9);
            if (j == 0)
                pokemon = new Bulbasaur(rand2.Next(highestlvl - 2, highestlvl + 3));
            else if (j == 1)
                pokemon = new Squirtle(rand2.Next(highestlvl - 2, highestlvl + 3));
            else if (j == 2)
                pokemon = new Gyarados(rand2.Next(highestlvl - 2, highestlvl + 3));
            else if (j == 3)
                pokemon = new Clamperl(rand2.Next(highestlvl - 2, highestlvl + 3));
            else if (j == 4)
                pokemon = new Arcanine(rand2.Next(highestlvl - 2, highestlvl + 3));
            else if (j == 5)
                pokemon = new Rapidash(rand2.Next(highestlvl - 2, highestlvl + 3));
            else if (j == 6)
                pokemon = new Vileplume(rand2.Next(highestlvl - 2, highestlvl + 3));
            else if (j == 7)
                pokemon = new Tangela(rand2.Next(highestlvl - 2, highestlvl + 3));
            else
                pokemon = new Charmander(rand2.Next(highestlvl - 2, highestlvl + 3));
            return pokemon;
        }

        public void Attack(int movechoice)
        {
            int percent = rand.Next(1, 101);
            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 1 || ((MainWindow)Application.Current.MainWindow).getBattleType() == 4)
            {
                if (percent < user.pokemon[pokechoice].moves[movechoice].percentHit)
                {
                    if (wild.type == user.pokemon[pokechoice].moves[movechoice].type || user.pokemon[pokechoice].moves[movechoice].type == 0) // if wild is same as user attack or tackle
                    {
                        status.Text = user.pokemon[pokechoice].name + " used " + user.pokemon[pokechoice].moves[movechoice].name + ". It hit!";
                        wild.health -= (int)Math.Ceiling(user.pokemon[pokechoice].moves[movechoice].power * user.pokemon[pokechoice].attack / 30 * 1.0);

                    }
                    else if (((wild.type + 1) % 3) == user.pokemon[pokechoice].moves[movechoice].type) // if wild is weak to user attack
                    {
                        wild.health -= (int)Math.Ceiling(user.pokemon[pokechoice].moves[movechoice].power * 1.3 * user.pokemon[pokechoice].attack / 30);
                        status.Text = user.pokemon[pokechoice].name + " used " + user.pokemon[pokechoice].moves[movechoice].name +  ". It was super effective!";
                    }

                    else // if wild is storng to user attack
                    {
                        wild.health -= (int)Math.Ceiling(user.pokemon[pokechoice].moves[movechoice].power * .7 * user.pokemon[pokechoice].attack / 30);
                        status.Text = user.pokemon[pokechoice].name + " used " + user.pokemon[pokechoice].moves[movechoice].name + ". It was not very effective.";
                    }

                    if (wild.health > 0)
                    {
                        ehp.Text = wild.health.ToString() + " / " + wild.maxhealth.ToString();
                        return;
                    }
                    else
                    {
                        ehp.Text = " 0 / " + wild.maxhealth.ToString();
                        MessageBox.Show(wild.name + " has fainted!");
                        user.pokemon[pokechoice].exp += 10 - (user.pokemon[pokechoice].level - wild.level);
                        if (user.pokemon[pokechoice].exp >= 100)
                        {
                            user.pokemon[pokechoice].exp -= 100;
                            user.pokemon[pokechoice].level++;
                            user.pokemon[pokechoice].health = user.pokemon[pokechoice].setMaxHealth(user.pokemon[pokechoice].level);
                            user.pokemon[pokechoice].maxhealth = user.pokemon[pokechoice].setMaxHealth(user.pokemon[pokechoice].level);
                            user.pokemon[pokechoice].attack = user.pokemon[pokechoice].setAttack(user.pokemon[pokechoice].level);
                            assignMove();

                        }

                        user.current = 0;
                        ((MainWindow)Application.Current.MainWindow).setUser(user);
                    }
                }
                else
                {
                    status.Text = "Your attack missed!";
                }
            }
            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 2 || ((MainWindow)Application.Current.MainWindow).getBattleType() == 3)
            {
                if (percent < user.pokemon[pokechoice].moves[movechoice].percentHit)
                {
                    if (enemy.pokemon[enchoice].type == user.pokemon[pokechoice].moves[movechoice].type || user.pokemon[pokechoice].moves[movechoice].type == 0) 
                    {
                        status.Text = user.pokemon[pokechoice].name + " used " + user.pokemon[pokechoice].moves[movechoice].name + ". It hit!";
                        enemy.pokemon[enchoice].health -= user.pokemon[pokechoice].moves[movechoice].power;

                    }
                    else if (((enemy.pokemon[enchoice].type + 1) % 3) == user.pokemon[pokechoice].moves[movechoice].type) 
                    {
                        enemy.pokemon[enchoice].health -= (int)Math.Ceiling(user.pokemon[pokechoice].moves[movechoice].power * 1.3);
                        status.Text = user.pokemon[pokechoice].name + " used " + user.pokemon[pokechoice].moves[movechoice].name + ". It was super effective!";
                    }
                    else
                    {
                        enemy.pokemon[enchoice].health -= (int)Math.Ceiling(user.pokemon[pokechoice].moves[movechoice].power * .7);
                        status.Text = user.pokemon[pokechoice].name + " used " + user.pokemon[pokechoice].moves[movechoice].name + ". It was not very effective.";
                    }

                    if (enemy.pokemon[enchoice].health > 0)
                    {
                        ehp.Text = (enemy.pokemon[enchoice].health.ToString() + " / " + (enemy.pokemon[enchoice].maxhealth.ToString()));
                        return;
                    }
                    else
                    {
                        ehp.Text = " 0 / " + enemy.pokemon[enchoice].maxhealth.ToString();
                        MessageBox.Show("Enemy " + enemy.pokemon[enchoice].name + " has fainted!");


                        user.pokemon[pokechoice].exp += 10 - (user.pokemon[pokechoice].level - enemy.pokemon[enchoice].level);
                        enemy.current--;
                        enchoice--;
                        if (user.pokemon[pokechoice].exp >= 100)
                        {
                            user.pokemon[pokechoice].exp -= 100;
                            user.pokemon[pokechoice].level++;
                            user.pokemon[pokechoice].health = Convert.ToInt32(user.pokemon[pokechoice].level * 2.1) + 30;
                            user.pokemon[pokechoice].maxhealth = Convert.ToInt32(user.pokemon[pokechoice].level * 2.1) + 30;
                            user.pokemon[pokechoice].attack = Convert.ToInt32(user.pokemon[pokechoice].level * 1.7) + 20;
                            assignMove();
                        }

                        user.current = 0;
                        pokechoice = 0;
                        ((MainWindow)Application.Current.MainWindow).setUser(user);
                        ((MainWindow)Application.Current.MainWindow).setEnemy(enemy);

                    }
                }
                else
                {
                    status.Text = "Your attack missed!";
                }
            }
        }

        public void assignMove()
        {
            if (user.pokemon[pokechoice].level >= 15 && user.pokemon[pokechoice].type == 1)
                user.pokemon[pokechoice].moves[2] = new FrenzyPlant();
            if (user.pokemon[pokechoice].level >= 15 && user.pokemon[pokechoice].type == 2)
                user.pokemon[pokechoice].moves[2] = new BlazeKick();
            if (user.pokemon[pokechoice].level >= 15 && user.pokemon[pokechoice].type == 3)
                user.pokemon[pokechoice].moves[2] = new WaterPulse();
            if (user.pokemon[pokechoice].level >= 30 && user.pokemon[pokechoice].type == 1)
                user.pokemon[pokechoice].moves[3] = new LeafBlade();
            if (user.pokemon[pokechoice].level >= 30 && user.pokemon[pokechoice].type == 2)
                user.pokemon[pokechoice].moves[3] = new Eruption();
            if (user.pokemon[pokechoice].level >= 30 && user.pokemon[pokechoice].type == 3)
                user.pokemon[pokechoice].moves[3] = new HydroCannon();

        }

        public void eAttack()
        {
            int percent = rand.Next(1, 101);
            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 1 || ((MainWindow)Application.Current.MainWindow).getBattleType() == 4)
            {
                int movechoice = rand2.Next(0, wild.movecount);
                if (percent < wild.moves[movechoice].percentHit)
                {
                    if (user.pokemon[pokechoice].type == wild.moves[movechoice].type || wild.moves[movechoice].type == 0)
                    {
                        estatus.Text = wild.name + " used " + wild.moves[movechoice].name + ". It hit!";
                        user.pokemon[pokechoice].health -= (int)Math.Ceiling(wild.moves[movechoice].power * wild.attack / 30 * 1.0);

                    }
                    else if (((user.pokemon[pokechoice].type + 1) % 3) == wild.moves[movechoice].type)
                    {
                        user.pokemon[pokechoice].health -= (int)Math.Ceiling(wild.moves[movechoice].power * 1.3 * wild.attack / 30);
                        estatus.Text = wild.name + " used " + wild.moves[movechoice].name +  ". It was super effective!";
                    }
                    else
                    {
                        user.pokemon[pokechoice].health -= (int)Math.Ceiling(wild.moves[movechoice].power * .7 * wild.attack / 30);
                        estatus.Text = wild.name + " used " + wild.moves[movechoice].name + ". It was not very effective.";
                    }

                    if (user.pokemon[pokechoice].health > 0)
                    {
                        ihp.Text = user.pokemon[pokechoice].health.ToString() + " / " + user.pokemon[pokechoice].maxhealth.ToString();
                        return;
                    }
                    else
                    {
                        user.pokemon[pokechoice].health = 0;
                        ihp.Text = " 0 / " + user.pokemon[pokechoice].maxhealth.ToString();
                        ((MainWindow)Application.Current.MainWindow).setDead(true);
                        for (int i = 0; i < user.pokecount; i++)
                        {
                            if (user.pokemon[i].health > 0)
                            {
                                MessageBox.Show("Your " + user.pokemon[pokechoice].name + " has fainted! Swapped to " + user.pokemon[i].name + "!");
                                user.current = i;
                                pokechoice = user.current;
                                poke1.Source = user.pokemon[pokechoice].bitmap;
                                ihp.Text = user.pokemon[pokechoice].health.ToString() + " / " + user.pokemon[pokechoice].maxhealth.ToString();
                                ilvl.Text = "Lv. " + user.pokemon[pokechoice].level.ToString() + "\t Exp: " + user.pokemon[pokechoice].exp.ToString() + " / 100";
                                ((MainWindow)Application.Current.MainWindow).setDead(false);
                                break;
                            }
                        }
                        if (((MainWindow)Application.Current.MainWindow).getDead())
                        {
                            MessageBox.Show("All your pokemon fainted, you should run away!");
                        }
                        ((MainWindow)Application.Current.MainWindow).setUser(user);
                    }
                }
                else
                {
                    estatus.Text = "Enemy attack missed!";
                }
            }
            if (((MainWindow)Application.Current.MainWindow).getBattleType() == 2 || ((MainWindow)Application.Current.MainWindow).getBattleType() == 3)
            {
                int movechoice = rand.Next(0, enemy.pokemon[enchoice].movecount);
                if (percent < enemy.pokemon[enchoice].moves[movechoice].percentHit)
                {
                    if (user.pokemon[pokechoice].type == enemy.pokemon[enchoice].moves[movechoice].type || enemy.pokemon[enchoice].moves[movechoice].type == 0)
                    {
                        estatus.Text = enemy.pokemon[enchoice].name + " used " + enemy.pokemon[enchoice].moves[movechoice].name + ". It hit!";
                        user.pokemon[pokechoice].health -= enemy.pokemon[enchoice].moves[movechoice].power;

                    }
                    else if (((user.pokemon[pokechoice].type + 1) % 3) == enemy.pokemon[enchoice].moves[movechoice].type) 
                    {
                        user.pokemon[pokechoice].health -= (int)Math.Ceiling(enemy.pokemon[enchoice].moves[movechoice].power * 1.3);
                        estatus.Text = enemy.pokemon[enchoice].name + " used " + enemy.pokemon[enchoice].moves[movechoice].name + ". It was super effective!";
                    }
                    else 
                    {
                        user.pokemon[pokechoice].health -= (int)Math.Ceiling(enemy.pokemon[enchoice].moves[movechoice].power * .7);
                        estatus.Text = enemy.pokemon[enchoice].name + " used " + enemy.pokemon[enchoice].moves[movechoice].name + ". It was not very effective.";
                    }

                    if (user.pokemon[pokechoice].health > 0)
                    {
                        ihp.Text = (user.pokemon[pokechoice].health.ToString() + " / " + (user.pokemon[pokechoice].maxhealth.ToString()));
                        return;
                    }
                    else
                    {
                        user.pokemon[pokechoice].health = 0;
                        ihp.Text = " 0 / " + user.pokemon[pokechoice].maxhealth.ToString();
                        ((MainWindow)Application.Current.MainWindow).setDead(true);
                        for (int i = 0; i < user.pokecount; i++)
                        {
                            if (user.pokemon[i].health > 0)
                            {
                                MessageBox.Show("Your " + user.pokemon[pokechoice].name + " has fainted! Swapped to " + user.pokemon[i].name + "!");
                                user.current = i;
                                pokechoice = user.current;
                                poke1.Source = user.pokemon[pokechoice].bitmap;
                                ihp.Text = user.pokemon[pokechoice].health.ToString() + " / " + user.pokemon[pokechoice].maxhealth.ToString();
                                ilvl.Text = "Lv. " + user.pokemon[pokechoice].level.ToString() + "\t Exp: " + user.pokemon[pokechoice].exp.ToString() + " / 100";
                                ((MainWindow)Application.Current.MainWindow).setDead(false);
                                break;
                            }
                        }
                        if (((MainWindow)Application.Current.MainWindow).getDead())
                        {
                            MessageBox.Show("All your pokemon fainted, you should run away!");
                        }

                        ((MainWindow)Application.Current.MainWindow).setUser(user);
                        ((MainWindow)Application.Current.MainWindow).setEnemy(enemy);

                    }
                }
                else
                {
                    estatus.Text = "Enemy attack missed!";
                }
            }
        }
    }
}
