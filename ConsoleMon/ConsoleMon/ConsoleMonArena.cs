using System;

namespace ConsoleMon
{
    class ConsoleMonArena
    {
        internal void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random rand = new Random();
            Skill skall = a.Skills[rand.Next(a.Skills.Count)];
            Console.WriteLine("this is A "+skall.name);

            Skill skbll = b.Skills[rand.Next(b.Skills.Count)];
            Console.WriteLine("this is B " +skbll.name);

            skbll.UseOn(b,a);
            skall.UseOn(a, b);

            Console.WriteLine(a.hp);
            Console.WriteLine(b.hp);
        }

    }
}
