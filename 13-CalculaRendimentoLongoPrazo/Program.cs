using System;

namespace _13_CalculaRendimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13 - Calculo de Rendimento a longo prazo");
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;
            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <=12; j++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine($"Ao término do rendimento, você terá: R${valorInvestido}");
        }
    }
}
