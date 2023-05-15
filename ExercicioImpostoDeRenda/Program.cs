using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        double aliquota = 0;
        int restituicao = 0;

        if (1900 < salario && salario <= 2800)
        {
            aliquota = 7.5;
            restituicao = 142;
        }

        if (2800 < salario && salario <= 3751)
        {
            aliquota = 15;
            restituicao = 350;
        }

        if (3750 < salario && salario <= 4664)
        {
            aliquota = 22.5;
            restituicao = 636;
        }

        Console.WriteLine(
            $"Sua alíquota do imposto de renda é de {aliquota}% e você pode restituir até R$ {restituicao}");
    }
}