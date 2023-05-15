using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 1;

        bool acompanhado = quantidadePessoas > 1;
        string textoAdicional;
        
        if (acompanhado)
        {
            textoAdicional = "João está acompanhado.";
        } else
        {
            textoAdicional = "João não está acompanhado.";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {   
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar.");
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}