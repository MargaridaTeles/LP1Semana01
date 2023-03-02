using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            string xx2 = $"xx={xx:f2}";
            string decix = String.Format("{0:p1}", xx);
            int ii = 18;

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


            Console.WriteLine(xx2);
            Console.WriteLine(decix);
            Console.WriteLine(ii.ToString("X"));
            Console.WriteLine(ii.ToString("C"));
        }
    }
}
