using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {            Console.WriteLine("Projeto 5");

            char primeiraLetra = (char) 61; //tabela ascii
            primeiraLetra += (char)1;
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            string cursosProgramacao = @" - .NET  
 - Java
 - Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
        }
    }
}
