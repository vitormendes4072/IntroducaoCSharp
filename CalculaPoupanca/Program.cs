using System;

namespace _12_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - Calcula Poupança");
            double valorInvestido = 1000;

            /*
             *  valorInvestido = valorInvestido + valorInvestido * (0.36 / 100);
             *  Console.WriteLine($"Após 1 mês, você terá R$ {valorInvestido}");
             *
             *  valorInvestido = valorInvestido + valorInvestido * (0.36 / 100);
             *  Console.WriteLine($"Após 2 meses, você terá R$ {valorInvestido}");
             */

            /*  Contador utilizando While
             *  int contador = 0;
             *  while (contador < 12)
             *  {
             *      contador++;
             *      valorInvestido = valorInvestido + valorInvestido * (0.36 / 100);
             *       Console.WriteLine($"Após {contador} meses, você terá R$ {valorInvestido}");
             *  }
             */

            // Contador utilizando for
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"Após {i} meses, você terá R$ {valorInvestido}");
            }
        }
    }
}
