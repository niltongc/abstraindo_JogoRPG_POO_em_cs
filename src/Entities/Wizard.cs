using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_desafio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string hero_type) : base(name, level, hero_type)
        {

        }

        public override void Attack()
        {
            base.damage = Damage();
            if (base.damage > 5)
            {
                System.Console.WriteLine("Ataque efetivo" );
            }
            else
            {
                System.Console.WriteLine("Ataque muito próximo");
            }
            System.Console.WriteLine($"{this.name} causou {base.damage} de dano \n");
        }
    }
}