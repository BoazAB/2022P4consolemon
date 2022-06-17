using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class Skill
    {
        private int damage;
        private int energyCost;
        private string name;
        private string element = "Elementen.fire";

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }

        internal Skill()
        {

        }

        internal Skill()
        {

        }
    }
}
