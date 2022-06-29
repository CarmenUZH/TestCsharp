//Needs to be in the same folder as Program if Program uses it
using System.Collections.Generic;
namespace GradeBook
{
  public class Book{
    public Book(string Bookname)
    { //constructor method
      this.Bookname = Bookname; //Public variables usually have upper-case names
      noten = new List<double>(); //class variable
      
    }

    double highestPossibleGrade = 6; // code smell hehe :]
    double lowestPossibleGrade = 1;
    double myHighestGrade = double.MinValue; //Lowest possible double to start out

    public List<double> noten; //even if in constructor, needs to be in class too
    public string Bookname;

        public void AddGrade(double note){ //Non static, requires book to work (Instance Method)
      if (note >= lowestPossibleGrade && note <=highestPossibleGrade){
        noten.Add(note);
      }
      else{
        System.Console.WriteLine("Trying to add illegal grade");
      }
            }

    public void RemoveGrade(double note){
        if(noten.Contains(note)){
          noten.Remove(note);
        }
        else{
          System.Console.WriteLine("Trying to remove grade that isn't there");
        }
      }
      private double FindHighest(){
        foreach (double number in noten){
          if (number > myHighestGrade)
          myHighestGrade=number;
        }
        return myHighestGrade;
        
      }

      private double FindLowest(){
        return noten.AsQueryable().Min();
      }

      private double FindAverage(){
        return noten.AsQueryable().Average();
      }

      public string GetName(){
        return Bookname;
      }
  


      public Statistics GetStatistics(){
        var result = new Statistics();
        result.Average = FindAverage();
        result.High = FindHighest();
        result.Low=FindLowest();
        

        return result;
      }
      public void ShowStatistics(){
         
                Console.WriteLine("The highest value: " + FindHighest()); //Average ist weeeeird
                System.Console.WriteLine("The lowest value: " + FindLowest());
                System.Console.WriteLine($"The average grade is {FindAverage():N2}"); //Formatting: Zwei zahlen nach dem Komma
                System.Console.WriteLine("The book belongs to: " + GetName());
      }
        }
}