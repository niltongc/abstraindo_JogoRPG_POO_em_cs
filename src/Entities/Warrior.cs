using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_desafio.src.Entities
{
    public class Warrior : Hero
    {
        public bool long_range;
        public Warrior(string name, int level, string hero_type, bool long_range = true) : base(name, level, hero_type)
        {
            
        }

        public override void Attack()
        {
            base.damage = Damage();

            if (base.damage > 5)
            {
                System.Console.WriteLine("Ataque efetivo");
            }
            else
            {
                if (long_range)
                {
                    System.Console.WriteLine("Ataque muito próximo");
                }
                else
                {
                    System.Console.WriteLine("Ataque muito distante");

                }

            }

            System.Console.WriteLine($"{this.name} causou {base.damage} de dano \n");

        }
    }
}