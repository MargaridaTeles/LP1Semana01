using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumprimentar = "Olá!";
            string teste = @"C:\Users\teles\Documents";
            string Unicode = "que venha o ver\u00e3o";
            string escape = "Um tab\t";

            Console.WriteLine(cumprimentar+", "+teste+" "+Unicode+"\n"+escape);

            string y = "34";
            string x = "a" + 2;
            Console.WriteLine("abc" + x);
            Console.WriteLine($"valor de x é {x}");
            Console.WriteLine( $"{x} mais {y} é igual a {x+y}");
            Console.WriteLine(String.Format("Y é {1}, X é {0}", x, y));
            Console.WriteLine(@"Verbatim com x={0}", x);
        }
    }
}
