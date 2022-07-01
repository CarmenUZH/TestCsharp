//Needs to be in the same folder as Program if Program uses it
namespace GradeBook
{
    public abstract class BookBased : NamedObject, IBook
    {
        protected BookBased(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();

        public abstract void ShowStatistics();
        //you dont KNOW the implementation, keine geschweiften klammern
        //abstract methods CAN have implementation details but dont need to, Interfaces are not allowed to have implementation details
    }
}