using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 04 - Conversões e outros tipos de variáveis");
        
        //isso é um comentário
        double salario = 3000.15;
        Console.WriteLine($"double: {salario}");
        
        int salarioInteiro = (int)salario;
        Console.WriteLine($"salarioInteiro: {salarioInteiro}");

        long longNumber = 2000000000000000000;
        Console.WriteLine($"long: {longNumber}");

        short shortNumber = 1500;
        Console.WriteLine($"short: {shortNumber}");

        float altura = 1.62f;
        Console.WriteLine($"float: {altura}");
        
        
        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}