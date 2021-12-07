using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Maior de idade, pode entrar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Menor de idade, porém acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("Menor de idade, proibida a entrada");
                }
            }
        }
    }
}
