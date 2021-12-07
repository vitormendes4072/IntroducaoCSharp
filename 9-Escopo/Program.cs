using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado!";
            }
                else
            {
                mensagemAdicional = "Pode entrar.";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Proibida a entrada");
            }
        }
    }
}
