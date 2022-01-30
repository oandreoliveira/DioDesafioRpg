using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioDesafioRpg.Entities
{
    class Wizard : Hero

    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }


        public override string Attack()
        {
            return $"{Name} lançou magia!";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {

                return $"{Name} lançou magia super efetiva com bônus de {Bonus}!";
            }
            else
            {
                return $"{Name} lançou uma magia com força fraca com bônus de {Bonus}!";
            }
        }

    }
}
