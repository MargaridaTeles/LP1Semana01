using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int i = 8;
            uint j = 3U;
            long k = 16L;
            ulong n = 20UL;

            Console.WriteLine("Type Int: " + i);
            Console.WriteLine("Type UInt: " + j);
            Console.WriteLine("Type Long: " + k);
            Console.WriteLine("Type ULong: " + n);

            
            Console.OutputEncoding = Encoding.UTF8;

            char heart = '\u2764';
            char snowMan = '\u2603';
            char sun    = '\u2600';
            char music = '\u266B';

            Console.WriteLine("\nHeart Emoji: " + heart);
            Console.WriteLine("SnowMan Emoji: " + snowMan);
            Console.WriteLine("Sun Emoji: " + sun);
            Console.WriteLine("Music Emoji: " + music);


            float x = 10.5f;
            double y = 10.5;
            decimal z = 10.5m;

            Console.WriteLine("\nType Float: " + x);
            Console.WriteLine("Type Double: " + y);
            Console.WriteLine("Type Decimal: " + z);


            bool justTrue = true;
            bool justFalse = false;

            
        }
    }
}
