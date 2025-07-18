namespace CursoEjerciciosMicrosoft.ChallengesSolved
{
    /*
        Output values from 1 to 100, one number per line, within the code block of an iteration statement.
        If the current value is divisible by 3, the term Fizz is printed next to the number.
        If the current value is divisible by 5, the term Buzz is printed next to the number.
        If the current value is divisible by both 3 and 5, the term FizzBuzz is printed next to the number.
    */
    class FizzBuzz
    {
        #region methods
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine($"{i} - FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} - Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine($"{i} - Buzz");
                else
                    Console.WriteLine(i);
            }
        }
        #endregion
    }
}