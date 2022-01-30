using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioDesafioRpg.Entities
{
    class Knight : Hero
    {
        public Knight (string name, int level, string heroType) : base(name, level, heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
    }
}
