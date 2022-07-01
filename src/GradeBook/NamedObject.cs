//Needs to be in the same folder as Program if Program uses it
using System.Diagnostics.CodeAnalysis;

namespace GradeBook
{
    public class NamedObject //inherits from ultimate base class called "object"
    {
        public NamedObject(string name)
        {
            Bookname = name;
        }

        public string Bookname
        {
            get;
            set;
        }
    }
}