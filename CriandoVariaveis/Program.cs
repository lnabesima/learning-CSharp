using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 2 - Criando Variáveis");
        
        int idade;
        idade = 27;
        Console.WriteLine($"Minha idade é {idade}.");

        idade = idade - 5;
        Console.WriteLine($"A idade da Fulana é {idade}.");

        idade = (idade + 3) * 5;
        Console.WriteLine($"Mas a idade do Sicrano é {idade}.");
        
        Console.WriteLine("Pressione Enter para fechar...");
        Console.ReadLine();
    }
}