using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomekop
{
    public class User
    {
        public String name;
        public String rival;
        public Pokemon[] pokemon;
        public int pokecount; // amount of pokemon
        public int current; // Current pokemon selected
        public bool alive;
        public User()
        { }

        public User(string name, string rival)
        {
            this.name = name;
            this.rival = rival;
            pokemon = new Pokemon[6];
            this.pokecount = 0;
            this.current = 0;
            alive = true;
        }
    }
}
