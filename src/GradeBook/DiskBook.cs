//Needs to be in the same folder as Program if Program uses it
namespace GradeBook
{
    public class DiskBook: BookBased{


        public DiskBook(string bookname): base(bookname){
            this.Bookname = bookname;
        }

        public override void AddGrade(double grade)
        {
      string folder = @"C:\Temp\";  
// Filename  
string fileName = $"{Bookname}.txt";  
// Fullpath. You can direct hardcode it if you like.  
string fullPath = folder + fileName;  
// An array of strings  
  
// Write array of strings to a file using WriteAllLines.  
// If the file does not exists, it will create a new file.  
// This method automatically opens the file, writes to it, and closes file  
File.AppendAllText(fullPath, grade.ToString() + Environment.NewLine);  
// Read a file  
string readText = File.ReadAllText(fullPath);   
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        public override void ShowStatistics()
        {
            throw new NotImplementedException();
        }
    }
}