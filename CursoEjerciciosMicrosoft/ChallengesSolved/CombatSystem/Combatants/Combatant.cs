using CombatSystem.Utilities;

namespace CombatSystem.Combatants
{
    public abstract class Combatant
    {
        protected readonly IOutputWriter _outputWriter;
        protected readonly IRandomGenerator _randomGenerator;

        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int AttackPower { get; protected set; }
        public int Defense { get; protected set; }

        public bool IsAlive => Health > 0;

        public Combatant(string name, int health, int attackPower, int defense, IOutputWriter outputWriter, IRandomGenerator randomGenerator)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
            _outputWriter = outputWriter;
            _randomGenerator = randomGenerator;
        }

        public virtual void Attack(Combatant target)
        {
            int damage = _randomGenerator.Next(AttackPower / 2, AttackPower);
            _outputWriter.WriteLine($"{Name} attacks {target.Name} for {damage} damage.");
            target.TakeDamage(damage);
        }

        public virtual void TakeDamage(int damage)
        {
            int damageTaken = Math.Max(0, damage - Defense);
            Health -= damageTaken;
            _outputWriter.WriteLine($"{Name} takes {damageTaken} damage. Health: {Health}");
        }
    }
}