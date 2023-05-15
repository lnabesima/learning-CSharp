using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int counter = 1; counter <= 10; counter++)
        {
            int result = 1;
            for (int fatorial = counter; fatorial > 0; fatorial--)
            {
                result = result * fatorial;
            }
            Console.WriteLine($"O fatorial de {counter} é {result}.");
        }
    }
}