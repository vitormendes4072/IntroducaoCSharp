using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;
            int salarioEmInteiro = (int) salario;
            Console.WriteLine(salarioEmInteiro);

                                                //1 byte = 8 bits
            short bits16 = 32767;               //2 bytes = 16 bits -> -2^15 até 2^15  (5 digitos decimais)
            int bits32 = 2147483647;            //4 bytes = 32 bits -> -2^31 até 2^31  (10 digitos decimais)
            long bits64 = 9223372036854775807;  //8 bytes = 64 bits -> -2^63 até 2^63  (19 digitos decimais)

            float bits32f;                      //4 bytes = 32 bits
            double bits64f;                     //8 bytes = 64 bits
            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);
        }
    }
}
