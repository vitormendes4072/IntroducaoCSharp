using System;

namespace _10_TesteCondicionalAliquota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Teste Condicional de alíquota");
            double salario = 3300.0;
            if (salario >= 1900 && salario <= 2800)
            {
                Console.WriteLine("Sua aliquota é de 7.5%");
                Console.WriteLine("Você pode deduzir na declaração o  valor de R$ 142.00");
            }
            else if (salario > 2800 && salario <= 3751)
            {
                Console.WriteLine("Sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir na declaração o  valor de R$ 350.00");
            }
            else if (salario > 3751 && salario <= 4664)
            {
                Console.WriteLine("Sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir na declaração o  valor de R$ 636.00");
            }
        }
    }
}
