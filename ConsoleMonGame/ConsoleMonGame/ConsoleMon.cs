using System.Reflection.Metadata.Ecma335;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        private List<Skill> skills;

        internal int health;
        internal int energy;
        internal string name;

        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        
    }
}
