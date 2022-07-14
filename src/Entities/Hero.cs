using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_desafio.src.Entities
{
    public abstract class Hero
    {   
        public string name;
        public int level;
        public string hero_type;
        protected int damage;
        public Hero(string name, int level, string hero_type)
        {
            this.name = name;
            this.level = level;
            this.hero_type = hero_type;
        }

        public abstract void Attack();

        protected int Damage()
        {
            Random rnd = new Random();
            return rnd.Next(1,10);
        }



    }
}