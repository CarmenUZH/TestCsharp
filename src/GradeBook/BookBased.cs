//Needs to be in the same folder as Program if Program uses it
namespace GradeBook
{
    public abstract class BookBased : NamedObject{
        protected BookBased(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        //you dont KNOW the implementation, keine geschweiften klammern
      
    }
}