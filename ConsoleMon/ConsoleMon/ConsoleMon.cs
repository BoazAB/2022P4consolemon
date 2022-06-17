using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        private int hp;
        private float energy;
        private string name;
        private string weakness = "Elementen.water";

        List<Skill> Skills = new List<Skill>();
        class Skills
        {

        }

        public void TakeDamage(int damage)
        {
            hp = (hp - damage);
        }
        public void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
    }

    internal enum Elementen
    {
        fire,
        water,
        earth,
        air,
        wood,
        metal
    }
}
