using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int counter = 1; counter <= 100; counter++)
        {
            if (counter % 3 == 0)
            {
                Console.Write($"{counter}, ");
            }
        }
    }
}