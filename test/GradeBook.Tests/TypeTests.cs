using System;
using Xunit;
 
namespace GradeBook.Tests
{    

    public delegate string WriteLogDelegate(string logMessage); //delegates what a method is supposed to look like

    public class TypeTests
    {    
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage; //Point log to method
            //log += IncrementCount;

            var result = log("Hello!"); //Log was defined to point to ReturnMessage so this works
            Assert.Equal("Hello!", result);
        }


        /*
        string IncrementCount(string message) //Method you invoke
        {
            count++;
            return message.ToLower();
        }
*/
        string ReturnMessage(string message)  //Method you invoke
        {
            count++;
            return message;
        }


    }
}