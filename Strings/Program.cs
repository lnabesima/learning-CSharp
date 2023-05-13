using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa 5.5 - Strings");
        
        string primeiraFrase = "Alura - Cursos de Tecnologia";
        Console.WriteLine(primeiraFrase);

        string cursosDisponíveis = @"Cursos disponíveis:
- Go;
- C#;
- Python;
- Java";
        Console.WriteLine(cursosDisponíveis);
        
        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}