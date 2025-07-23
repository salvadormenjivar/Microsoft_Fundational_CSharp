using CombatSystem.Utilities;

namespace CombatSystem.Combatants
{
    public class Hero : Combatant
    {
        public Hero(string name, int health, int attackPower, int defense, IOutputWriter outputWriter, IRandomGenerator randomGenerator)
            : base(name, health, attackPower, defense, outputWriter, randomGenerator)
        {
        }
    }
}