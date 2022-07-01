//Needs to be in the same folder as Program if Program uses it
namespace GradeBook

//abstract methods CAN have implementation details but dont need to, Interfaces are not allowed to have implementation details

{
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Bookname { get; }
        public void ShowStatistics();
        //event GradeAddedDelegate GradeAdded;
    }
}