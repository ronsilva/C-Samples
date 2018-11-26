﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Guess a number?");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == 12;

        do
        {
            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62. Try again.");
                    Console.WriteLine("Guess a number?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 29:
                    Console.WriteLine("You guessed 29. Try again.");
                    Console.WriteLine("Guess a number?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 55:
                    Console.WriteLine("You guessed 55. Try again.");
                    Console.WriteLine("Guess a number?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 12:
                    Console.WriteLine("You guessed 12. That is correct!.");
                    Console.WriteLine("Guess a number?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("You are wrong.");
                    Console.WriteLine("Guess a number?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!isGuessed);

        Console.Read();
    }
}

