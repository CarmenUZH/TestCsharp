﻿// See https://aka.ms/new-console-template for more information
//Wichtig: Whitespace ist semi wichtig: klammern müssen klar sein

using System;
namespace GradeBook
    {
  
    class Program //In Csharp a class defines a type, just like string
    {
    static void Main(string[] args)
        {
            double GetRandomNumber()
            { 
            Random random = new Random();
            return random.NextDouble() * (6 - 1) + 1;
            }

            double pi;
            pi = 3.14;
            var fi = 4.13; //var basically implies: "I know you'll be figure out that fi is a double (no explicit type needed)"

            var book = new Book("CarmensBook"); //needs to be initialized
            book.AddGrade(GetRandomNumber());
            book.AddGrade(GetRandomNumber());
            book.AddGrade(GetRandomNumber());
            book.AddGrade(pi);//Me in French LMAO
            book.AddGrade(fi);
            book.ShowStatistics();
            System.Console.WriteLine(book.GetStatistics().High);

            System.Console.WriteLine("______________________________________________________________________________");

            var secondbook = new Book("PhilsBook");
            secondbook.AddGrade(GetRandomNumber());
            secondbook.AddGrade(GetRandomNumber());
            secondbook.AddGrade(GetRandomNumber());
            secondbook.AddGrade(GetRandomNumber());
            secondbook.AddGrade(GetRandomNumber());
            secondbook.ShowStatistics();
           
/*
            double[] numbers = new double[7]; //Initialize an array
            numbers[0] = 1.44;
            numbers[1]= pi;
            numbers[2]= fi;

            var grades = new[]{6,4,3};
            fi += 5; 

            var result = 0.0;
            foreach(var number in noten){
                result += number; //adding all the numbers together
            }

            result = result / noten.Count; //How many items are in this list, makes loops unnecessary

            var anzNummern = 0; //Loop to count amount of entried
            foreach(double number in numbers){
                if(number > 0){ //Counts null too!!! Important!!
                anzNummern += 1;
            }}
*/
      
               
         
    }
    }
}