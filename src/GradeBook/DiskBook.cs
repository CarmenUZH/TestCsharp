//Needs to be in the same folder as Program if Program uses it
using System.Linq;

namespace GradeBook
{
    public class DiskBook: BookBased{

    string folder = @"C:\Temp\";  
        public DiskBook(string bookname): base(bookname){
            this.Bookname = bookname;
        }

        public override void AddGrade(double grade)
        {
  
// Filename  
string fileName = $"{Bookname}.txt";  
// Fullpath. You can direct hardcode it if you like.  
string fullPath = folder + fileName;  
// An array of strings  
  
// Write array of strings to a file using WriteAllLines.  
// If the file does not exists, it will create a new file.  
// This method automatically opens the file, writes to it, and closes file  
File.AppendAllText(fullPath, grade.ToString() + Environment.NewLine);   //You should wrap file thingis in using so that you can dispose it again
// Read a file  

        }

        public override Statistics GetStatistics()
        {
            string fileName = $"{Bookname}.txt";  
            // Fullpath. You can direct hardcode it if you like.  
            string fullPath = folder + fileName;  
            List <double> noten = new List<double> (); 
            string[] dienoten = File.ReadAllLines(fullPath);

            foreach(string note in dienoten){
                noten.Add(Double.Parse(note));
            }

            var result = new Statistics(noten);
        
            return result;
        }

        public override void ShowStatistics()
        {
            Console.WriteLine("The highest value: " + GetStatistics().High); //Average ist weeeeird
            System.Console.WriteLine($"The lowest value:  {GetStatistics().Low:N2}");
            System.Console.WriteLine($"The average grade is {GetStatistics().Average:N2}"); //Formatting: Zwei zahlen nach dem Komma
            System.Console.WriteLine("The book belongs to: " + Bookname);
        }
    }
}