using System;

namespace CombatSystem.Utilities
{
    public class DefaultRandomGenerator : IRandomGenerator
    {
        private readonly Random _random;

        public DefaultRandomGenerator()
        {
            _random = new Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}