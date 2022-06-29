
using System;

namespace GradeBook
{
    public static class Greeting //In Csharp a class defines a type, just like string
    {

        public static void SayHello(string[] args)
        {

            if (args.Length > 0)
            {
                Console.WriteLine("Hello, " + args[0] + "!"); //write cw and then tab to make console.writeline quickly
                Console.WriteLine($"Goodbye, {args[1]}!");
            }
            else
            {
                Console.WriteLine("Hi!");

            }
        }
    }
}