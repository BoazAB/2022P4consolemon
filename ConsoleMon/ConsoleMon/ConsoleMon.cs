using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        internal int hp;
        private float energy;
        private string name;
        private Elementen weakness = Elementen.water;

        internal List<Skill> Skills = new List<Skill>();

        public void TakeDamage(int damage)
        {
            hp = (hp - damage);
        }
        public void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
        internal ConsoleMon()
        {

        }
        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.hp = copyFrom.hp;
            this.energy = copyFrom.energy;
            this.name = copyFrom.name;
            this.Skills = copyFrom.Skills;
            foreach (Skill skill in copyFrom.Skills)
            {
                Skill clone = new Skill(skill);
                this.Skills.Add(clone);
            }
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
