using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoded
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = null;
            string encoded = null;

            Console.WriteLine("Welcome to Decoded v1.5");
            Console.WriteLine("Use '!' to exit");
            while (true)
            {
                Console.WriteLine("Enter what you would like to decode:");
                code = Console.ReadLine().ToLower();
                encoded = null;

                if (code == "!")
                {
                    Environment.Exit(0);
                }
                else if (code == "?")
                {
                    Console.WriteLine("Created by Markus Gudelis and Nolan Pilon");
                    Console.WriteLine("http://opticalraze.com");
                    Console.WriteLine("Codes");
                    Console.WriteLine("'A' : 'q', 'B' : 'w', 'C' : 'e', 'D' : 'r', 'E' : 't', 'F' : 'y', 'G' : 'u', 'H' : 'i', 'I' : 'o', 'J' : 'p', 'K' : 'a', 'L' : 's', 'M' : 'd', 'N' : 'f', 'O' : 'g', 'P' : 'h', 'Q' : 'j', 'R' : 'k', 'S' : 'l', 'T' : 'z', 'U' : 'x', 'V' : 'c', 'W' : 'v', 'X' : 'b', 'Y' : 'n', 'Z' : 'm'");
                    encoded = "Thanks for using Decoded";
                }
                else
                {

                }
                Console.WriteLine("The encoded message is: {0}", encoded);
            }
        }
    }
}
