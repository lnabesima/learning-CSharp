﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int contadorLinhas = 0; contadorLinhas <= 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= 10; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas) break;
            }
            Console.WriteLine();
        }

        for (int contadorLinhas = 0; contadorLinhas <= 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}