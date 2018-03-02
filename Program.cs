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
            int length;

            Console.WriteLine("Welcome to Encoded v1.0");
            Console.WriteLine("Use '!' to exit");
            while (true)
            {
                Console.WriteLine("Enter what you would like to encode:");
                code = Console.ReadLine().ToLower();
                length = code.Length;
                encoded = null;

                //Console.WriteLine(length);
                if (code != "")
                {

                }
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
                    for (int i = 0; i < length; i++)
                    {
                        char x = code[i];

                        switch (x)
                        {
                            case 'q':
                                encoded += "a";
                                break;
                            case 'w':
                                encoded += "b";
                                break;
                            case 'e':
                                encoded += "c";
                                break;
                            case 'r':
                                encoded += "d";
                                break;
                            case 't':
                                encoded += "e";
                                break;
                            case 'y':
                                encoded += "f";
                                break;
                            case 'u':
                                encoded += "g";
                                break;
                            case 'i':
                                encoded += "h";
                                break;
                            case 'o':
                                encoded += "i";
                                break;
                            case 'p':
                                encoded += "j";
                                break;
                            case 'a':
                                encoded += "k";
                                break;
                            case 's':
                                encoded += "l";
                                break;
                            case 'd':
                                encoded += "m";
                                break;
                            case 'f':
                                encoded += "n";
                                break;
                            case 'g':
                                encoded += "o";
                                break;
                            case 'h':
                                encoded += "p";
                                break;
                            case 'j':
                                encoded += "q";
                                break;
                            case 'k':
                                encoded += "r";
                                break;
                            case 'l':
                                encoded += "s";
                                break;
                            case 'z':
                                encoded += "t";
                                break;
                            case 'x':
                                encoded += "u";
                                break;
                            case 'c':
                                encoded += "v";
                                break;
                            case 'v':
                                encoded += "w";
                                break;
                            case 'b':
                                encoded += "x";
                                break;
                            case 'n':
                                encoded += "y";
                                break;
                            case 'm':
                                encoded += "z";
                                break;
                            case ' ':
                                encoded += " ";
                                break;
                            default:
                                encoded += "?";
                                break;
                        }
                    }
                }
                Console.WriteLine("The word is: {0}", encoded);
            }
        }
    }
}