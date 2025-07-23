using CombatSystem.Combatants;
using CombatSystem.Utilities;
using System.Threading;

namespace CombatSystem
{
    public class CombatSimulator
    {
        private readonly IOutputWriter _outputWriter;
        private readonly IRandomGenerator _randomGenerator;

        public CombatSimulator(IOutputWriter outputWriter, IRandomGenerator randomGenerator)
        {
            _outputWriter = outputWriter;
            _randomGenerator = randomGenerator;
        }

        public void SimulateCombat(Combatant combatant1, Combatant combatant2)
        {
            _outputWriter.WriteLine($"Combat between {combatant1.Name} and {combatant2.Name} begins!");

            while (combatant1.IsAlive && combatant2.IsAlive)
            {
                _outputWriter.WriteLine("\n--- New Round ---");
                combatant1.Attack(combatant2);
                if (!combatant2.IsAlive)
                {
                    _outputWriter.WriteLine($"{combatant2.Name} has been defeated!");
                    break;
                }

                combatant2.Attack(combatant1);
                if (!combatant1.IsAlive)
                {
                    _outputWriter.WriteLine($"{combatant1.Name} has been defeated!");
                    break;
                }
                Thread.Sleep(1000); // Simulate time passing between rounds
            }

            _outputWriter.WriteLine("\n--- Combat End ---");
            if (combatant1.IsAlive)
            {
                _outputWriter.WriteLine($"{combatant1.Name} is victorious!");
            }
            else if (combatant2.IsAlive)
            {
                _outputWriter.WriteLine($"{combatant2.Name} is victorious!");
            }
            else
            {
                _outputWriter.WriteLine("Both combatants fell. It's a draw!");
            }
        }
    }
}