using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace Nomekop
{
    public class Pokemon
    {
        public int level;
        public int exp;
        public int attack;
        public int health;
        public string name;
        public int type; // 1 grass, 2 fire, 3 water
        public int maxhealth;
        public Moves[] moves;
        public Uri uri;
        public BitmapImage bitmap;
        public int movecount;
        public bool alive;
        public float health_scale;
        public float health_base;
        public float attack_base;
        public float attack_scale;
        public Pokemon ShallowCopy()
        {
            return (Pokemon)this.MemberwiseClone();
        }

        public int setMaxHealth(int level)
        {
            return Convert.ToInt32(level * health_scale + health_base);
        }
        public int setAttack(int level)
        {
            return Convert.ToInt32(level * attack_scale + attack_base);
        }
    }

    class Grandmamon : Pokemon
    {
        public Grandmamon(int level, string name = "Grandma")
        {
            this.health_scale = 6.6f;
            this.health_base = 45f;
            this.attack_scale = 5.5f;
            this.attack_base = 20f;
            this.name = name;
            this.level = 100;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 1;
            moves = new Moves[4];
            moves[0] = new LeafBlade();
            moves[1] = new HydroCannon();
            moves[2] = new Eruption();
            moves[3] = new Tackle();
            uri = new Uri("pack://application:,,,/Resources/grandmamon.png");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
        }
    }

    class Bulbasaur : Pokemon
    {
        public Bulbasaur(int level, string name = "Bulbasaur")
        {
            this.health_scale = 4.2f;
            this.health_base = 45f;
            this.attack_scale = 1.7f;
            this.attack_base = 20f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 1;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new BulletSeed();
            uri = new Uri("pack://application:,,,/Resources/bulbasaur.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new FrenzyPlant();
            if (this.level >= 30)
                this.moves[3] = new LeafBlade();
        }
    }
    class Vileplume : Pokemon
    {
        public Vileplume(int level, string name = "Vileplume")
        {
            this.health_scale = 3.5f;
            this.health_base = 35f;
            this.attack_scale = 1.9f;
            this.attack_base = 24f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 1;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new BulletSeed();
            uri = new Uri("pack://application:,,,/Resources/vileplume.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new FrenzyPlant();
            if (this.level >= 30)
                this.moves[3] = new LeafBlade();
        }
    }
    class Tangela : Pokemon
    {
        public Tangela(int level, string name = "Tangela")
        {
            this.health_scale = 3.9f;
            this.health_base = 40f;
            this.attack_scale = 2.1f;
            this.attack_base = 24f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 1;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new BulletSeed();
            uri = new Uri("pack://application:,,,/Resources/tangela.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new FrenzyPlant();
            if (this.level >= 30)
                this.moves[3] = new LeafBlade();
        }
    }





    class Charmander : Pokemon
    {
        public Charmander(int level, string name ="Charmander")
        {
            this.health_scale = 3.0f;
            this.health_base = 25f;
            this.attack_scale = 2.2f;
            this.attack_base = 30f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 2;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new FireSpin();
            uri = new Uri("pack://application:,,,/Resources/charmander.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new BlazeKick();
            if (this.level >= 30)
                this.moves[3] = new Eruption();
        }
    }

    class Rapidash : Pokemon
    {
        public Rapidash(int level, string name = "Rapidash")
        {
            this.health_scale = 2.8f;
            this.health_base = 28f;
            this.attack_scale = 2.5f;
            this.attack_base = 33f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 2;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new FireSpin();
            uri = new Uri("pack://application:,,,/Resources/rapidash.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new BlazeKick();
            if (this.level >= 30)
                this.moves[3] = new Eruption();
        }
    }

    class Arcanine : Pokemon
    {
        public Arcanine(int level, string name = "Arcanine")
        {
            this.health_scale = 3.5f;
            this.health_base = 32f;
            this.attack_scale = 2.1f;
            this.attack_base = 25f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 2;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new FireSpin();
            uri = new Uri("pack://application:,,,/Resources/arcanine.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new BlazeKick();
            if (this.level >= 30)
                this.moves[3] = new Eruption();
        }
    }
    class Squirtle : Pokemon
    {
        public Squirtle(int level, string name = "Squirtle")
        {
            this.health_scale = 3.8f;
            this.health_base = 30f;
            this.attack_scale = 2f;
            this.attack_base = 25f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 3;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new Bubbles();
            uri = new Uri("pack://application:,,,/Resources/squirtle.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new WaterPulse();
            if (this.level >= 30)
                this.moves[3] = new HydroCannon();
        }
    }
    class Gyarados : Pokemon
    {
        public Gyarados(int level, string name = "Gyarados")
        {
            this.health_scale = 4.2f;
            this.health_base = 30f;
            this.attack_scale = 2.5f;
            this.attack_base = 30f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 3;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new Bubbles();
            uri = new Uri("pack://application:,,,/Resources/gyarados.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new WaterPulse();
            if (this.level >= 30)
                this.moves[3] = new HydroCannon();
        }
    }

    class Clamperl : Pokemon
    {
        public Clamperl(int level, string name = "Clamperl")
        {
            this.health_scale = 4f;
            this.health_base = 30f;
            this.attack_scale = 1.6f;
            this.attack_base = 20f;
            this.name = name;
            this.level = level;
            this.exp = 0;
            this.health = setMaxHealth(level);
            this.maxhealth = setMaxHealth(level);
            this.attack = setAttack(level);
            this.type = 3;
            moves = new Moves[4];
            moves[0] = new Tackle();
            moves[1] = new Bubbles();
            uri = new Uri("pack://application:,,,/Resources/clamperl.jpg");
            bitmap = new BitmapImage(uri);
            this.movecount = 2;
            alive = true;
            if (this.level >= 15)
                this.moves[2] = new WaterPulse();
            if (this.level >= 30)
                this.moves[3] = new HydroCannon();
        }
    }

}
