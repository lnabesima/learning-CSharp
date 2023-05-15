using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 12 - Investimento a Longo Prazo");

        double fatorInvestimento = 1.005;
        double investimento = 1000;

        for (int ano = 1; ano <= 5; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorInvestimento;
                Console.WriteLine($"Ao final do mês {mes} do ano {ano}, seu saldo investido será de R$ {investimento}.");
            }

            fatorInvestimento += 0.001;
        }
        
        
        Console.WriteLine("Tecle Enter para sair...");
        Console.ReadLine();
    }
}