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
        }
    }
}
