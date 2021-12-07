using System;

namespace _17_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int i = 1; 10 >= i; i++)
            {
                fatorial *= i;
                Console.WriteLine($"{i}! = {fatorial}");
            }

        }
    }
}
