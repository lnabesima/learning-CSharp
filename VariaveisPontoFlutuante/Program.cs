using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 03 - Variáveis tipo Ponto Flutuante");

        double salario;
        salario = 3000.13;
        Console.WriteLine($"salario: {salario}");

        double idade1;
        idade1 = 7 / 5;
        Console.WriteLine($"idade1: {idade1}");
        
        double idade2;
        idade2 = 7.0 / 5.0;
        Console.WriteLine($"idade2: {idade2}");
        
        Console.WriteLine("Pressione Enter para fechar...");
        Console.ReadLine();
    }
}