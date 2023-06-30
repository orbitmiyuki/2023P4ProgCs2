namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;
        internal Element element;

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(damage);
            caster.DepleteEnergy(energyCost);

            if (target.weakness == element)
            {
                target.TakeDamage(damage / 2);
            }
        } 

    }

}
