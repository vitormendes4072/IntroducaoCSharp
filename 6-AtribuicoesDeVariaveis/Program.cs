﻿using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6");
            int idade = 32;
            int idadeGustavo = idade;
            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);
        }
    }
}