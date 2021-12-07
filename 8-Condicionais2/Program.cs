using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8 - Condicionais 2");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Maior de idade ou acompanhado, pode entrar");
            }
            else
            {
                Console.WriteLine("Proibida a entrada");
            }
        }
    }
}
