﻿using CursoEjerciciosMicrosoft.ChallengesSolved;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select the challenge:");
        Console.WriteLine("1. FizzBuzz");
        Console.WriteLine("2. MonsterVsHero");
        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                FizzBuzz.Run();
                break;
            case "2":
                MonsterVsHero.Run();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}