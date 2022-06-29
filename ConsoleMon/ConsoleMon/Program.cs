namespace ConsoleMon
{
    class Program
    {
        static void Main()
        {
            ConsoleMon a = new ConsoleMon();
            ConsoleMon b = new ConsoleMon();

            Skill firePunch = new Skill();
            Skill waterPunch = new Skill();
            Skill airPunch = new Skill();
            Skill metalPunch = new Skill();

            a.Skills.Add(firePunch);
            a.Skills.Add(airPunch);
            b.Skills.Add(waterPunch);
            b.Skills.Add(metalPunch);

            ConsoleMonArena arena = new ConsoleMonArena();
            arena.DoBattle(a, b);
        }
    }
}
