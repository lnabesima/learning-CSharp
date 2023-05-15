using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 10 - Calcula Poupança");
        
        double investimento = 1000;
        double taxa = 0.005;
        /*
        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * taxa;
            Console.WriteLine($"No mês {mes} seu saldo investido é de R$ {investimento}");

            mes++;
        }*/

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= (taxa+1);
            Console.WriteLine($"No mês {mes}, seu saldo investido é de R$ {investimento}.");
        }
        
        Console.WriteLine("Tecle Enter para sair...");
        Console.ReadLine();
    }
}