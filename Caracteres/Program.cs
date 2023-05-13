using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 05 - Caracteres");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);
        
        Console.WriteLine("Pressione Enter para fechar...");
        Console.ReadLine();
    }
}