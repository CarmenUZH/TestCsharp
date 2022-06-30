//Needs to be in the same folder as Program if Program uses it
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {
        public Book(string Bookname)
        { //constructor method
            this.Bookname = Bookname; //Public variables usually have upper-case names
            noten = new List<double>(); //class variable

        }

        double highestPossibleGrade = 6; // code smell hehe :]
        double lowestPossibleGrade = 1;
        double myHighestGrade = double.MinValue; //Lowest possible double to start out

        public List<double> noten; //even if in constructor, needs to be in class too
        private string Bookname;

        public void AddGrade(double note)
        { //Non static, requires book to work (Instance Method)
            if (note >= lowestPossibleGrade && note <= highestPossibleGrade)
            {
                noten.Add(note);
            }
            else
            {
                System.Console.WriteLine("Trying to add illegal grade");
                throw new ArgumentException($"You cannot add this grade {nameof(note)}"); //Exceptions!! Like in Software Construction!!
            }
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(6);
                    break; //We need to explicitly tell C# to stop the case
                case 'B':
                    AddGrade(5);
                    break;
                case 'C':
                    AddGrade(4);
                    break;
                case 'D':
                    AddGrade(3);
                    break;
                case 'E':
                    AddGrade(2);
                    break;
                case 'F':
                    AddGrade(1);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void RemoveGrade(double note)
        {
            if (noten.Contains(note))
            {
                noten.Remove(note);
            }
            else
            {
                System.Console.WriteLine("Trying to remove grade that isn't there");
            }
        }
        private double FindHighest()
        {
            foreach (double number in noten)
            {
                if (number > myHighestGrade)
                    myHighestGrade = number;
            }
            return myHighestGrade;

        }

        private double FindLowest()
        {
            return noten.AsQueryable().Min();
        }

        private double FindAverage()
        {
            return noten.AsQueryable().Average();
        }

        public string GetName()
        {
            return Bookname;
        }


        public void SetName(string newname)
        {
            this.Bookname = newname;
        }

        public int[] LoopMe()
        { //An example function to test out loops in C#
            var loopstopper = 5;

            do
            {
                System.Console.WriteLine("This is a Loop");
                --loopstopper; //Gets passed as refrence! Huh!
            } while (loopstopper != 0);
            var funny = new List<string>(); //dont forgett var
            for (var amount = 0; amount < 4; amount += 1)
            {
                funny.Add("Hehe");
            }
            Random rnd = new Random();

            var thenumber = new List<int>();
            while (thenumber.Count() < 20)
            {
                if (thenumber.Contains(69))
                {
                    break; //There is also "continue" which would go out of the if statement
                }
                thenumber.Add(rnd.Next(65, 71));

            }

            int[] solution = { loopstopper, funny.Count(), thenumber.Last() };
            return solution;
        }


        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = FindAverage();
            result.High = FindHighest();
            result.Low = FindLowest();

            switch (result.Average)
            {
                case var d when d >= 5.5:
                    result.Letter = 'A';
                    break;
                case var d when d >= 4.5:
                    result.Letter = 'B';
                    break;

                case var d when d >= 3.5:
                    result.Letter = 'C';
                    break;
                case var d when d >= 2.5:
                    result.Letter = 'D';
                    break;

                case var d when d >= 2:
                    result.Letter = 'E';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }
            return result;
        }



        public void ShowStatistics()
        {

            Console.WriteLine("The highest value: " + FindHighest()); //Average ist weeeeird
            System.Console.WriteLine("The lowest value: " + FindLowest());
            System.Console.WriteLine($"The average grade is {FindAverage():N2}"); //Formatting: Zwei zahlen nach dem Komma
            System.Console.WriteLine("The book belongs to: " + GetName());
        }
    }
}