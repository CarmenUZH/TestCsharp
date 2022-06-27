// See https://aka.ms/new-console-template for more information
//Wichtig: Whitespace ist semi wichtig: klammern müssen klar sein
using System;
namespace GradeBook
    {
    class Program
    {
    static void Main(string[] args) 
        { 
            Console.WriteLine("Hello, " + args[0] + "!");
            Console.WriteLine($"Goodbye, {args[1]}!");
    }
    }
}