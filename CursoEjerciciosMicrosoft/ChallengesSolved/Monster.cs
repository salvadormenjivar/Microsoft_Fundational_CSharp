namespace CursoEjerciciosMicrosoft.ChallengesSolved
{
    /*
        Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
        El héroe y el monstruo comenzarán con 10 puntos de salud.
        Todos los ataques tendrán un valor comprendido entre 1 y 10.
        El héroe ataca primero.
        Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
        Si la salud del monstruo es mayor que 0, puede atacar al héroe.
        Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
        Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
        Imprima el ganador.
    */
    class MonsterVsHero
    {
        #region methods
        public static void Run()
        {
            Random randomAttack = new Random();
            int monsterLife = 10;
            int heroLife = 10;
            bool firstAttack = true;

            while (monsterLife > 0 && heroLife > 0)
            {
                int attack = randomAttack.Next(1, 10);
                if (firstAttack)
                {
                    monsterLife -= attack;
                    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterLife} health.");
                }
                else
                {
                    heroLife -= attack;
                    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroLife} health.");
                }
                firstAttack = !firstAttack;
            }
            Console.WriteLine(heroLife > monsterLife ? "Hero Wins" : "Monster Wins");
        }
        #endregion
    }
}