using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomekop
{
    public class Moves
    {
        public int percentHit;
        public int power;
        public string name;
        public int type;
        public int pp;
        public int maxpp;
    }

    public class Tackle : Moves
    {
        public Tackle()
        {
            this.percentHit = 100;
            this.power = 20;
            this.name = "Tackle";
            this.pp = 20;
            this.maxpp = 20;
            this.type = 0;
        }
    }
    public class BulletSeed : Moves
    {
        public BulletSeed()
        {
            this.percentHit = 100;
            this.power = 12;
            this.name = "Bullet Seed";
            this.pp = 30;
            this.maxpp = 30;
            this.type = 1;
        }
    }

    public class FrenzyPlant : Moves
    {
        public FrenzyPlant()
        {
            this.percentHit = 90;
            this.power = 25;
            this.name = "Frenzy Plant";
            this.pp = 20;
            this.maxpp = 20;
            this.type = 1;
        }
    }

    public class LeafBlade : Moves
    {
        public LeafBlade()
        {
            this.percentHit = 90;
            this.power = 40;
            this.name = "Leaf Blade";
            this.pp = 10;
            this.maxpp = 10;
            this.type = 1;
        }
    }

    public class FireSpin : Moves
    {
        public FireSpin()
        {
            this.percentHit = 85;
            this.power = 25;
            this.name = "Fire Spin";
            this.pp = 15;
            this.maxpp = 15;
            this.type = 2;
        }
    }

    public class BlazeKick : Moves
    {
        public BlazeKick()
        {
            this.percentHit = 75;
            this.power = 35;
            this.name = "Blaze Kick";
            this.pp = 15;
            this.maxpp = 15;
            this.type = 2;
        }
    }

    public class Eruption : Moves
    {
        public Eruption()
        {
            this.percentHit = 65;
            this.power = 60;
            this.name = "Eruption";
            this.pp = 10;
            this.maxpp = 10;
            this.type = 2;
        }
    }
    public class Bubbles : Moves
    {
        public Bubbles()
        {
            this.percentHit = 95;
            this.power = 15;
            this.name = "Bubbles";
            this.pp = 20;
            this.maxpp = 20;
            this.type = 3;
        }
    }

    public class WaterPulse : Moves
    {
        public WaterPulse()
        {
            this.percentHit = 90;
            this.power = 30;
            this.name = "Water Pulse";
            this.pp = 20;
            this.maxpp = 20;
            this.type = 3;
        }
    }

    public class HydroCannon : Moves
    {
        public HydroCannon()
        {
            this.percentHit = 80;
            this.power = 50;
            this.name = "Hydro Cannon";
            this.pp = 10;
            this.maxpp = 10;
            this.type = 3;
        }
    }
}
