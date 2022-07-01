// See https://aka.ms/new-console-template for more information
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

            IBook book = new InMemoryBook("CarmensBook"); //needs to be initialized
            book.AddGrade(GetRandomNumber());
            //book.AddGrade('A'); //Overload, but compiler knows which one i mean
            book.AddGrade(GetRandomNumber());
            book.AddGrade(pi);//Me in French LMAO
            book.AddGrade(fi);


            Console.WriteLine($"Are you ready to see your Grades, {book.Bookname}? [Y] [N]");
            var input = Console.ReadLine();
            var done = false;
            input = AskingForYes(input, done); //See method on bottom

            book.ShowStatistics();
            var stats = book.GetStatistics();
            System.Console.WriteLine($"The Letter is {stats.Letter}");

            System.Console.WriteLine("______________________________________________________________________________");

            IBook secondbook = new DiskBook("PhilsBook");
            secondbook.AddGrade(GetRandomNumber());
            secondbook.AddGrade(GetRandomNumber());
            secondbook.AddGrade(GetRandomNumber());
            secondbook.AddGrade(5);
            secondbook.AddGrade(GetRandomNumber());
            string imsaying = InMemoryBook.CONSTANTSTRING; //Because CONSTANTSTRING is constant i can treat it like a static thingy
            System.Console.WriteLine(imsaying);
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
        //If i had a method for EnterGrades i would have to use BookBased because polymorphism
        private static string? AskingForYes(string? input, bool done) //Refactoring! Enables Polymorphism
        {
            while (!done)
            {
                if (input == "Y" || input == "y")
                {
                    break;
                }

                //Check his code to see example of Try and Catch ( Or check SoftCon)

                Console.WriteLine("Im asking again: Are you ready?");
                input = Console.ReadLine(); //WHILE LOOP!! NEVER FORGET

            }

            return input;
        }
    }
}