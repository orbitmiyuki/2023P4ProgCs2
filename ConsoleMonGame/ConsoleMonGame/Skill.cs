namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(damage);
            caster.DepleteEnergy(energyCost);
        }

    }

}
