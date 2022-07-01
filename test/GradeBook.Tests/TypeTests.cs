using System;
using Xunit;

namespace GradeBook.Tests //It will say that only one "testdatei stimmt mit dem muster überein" but it means both TypeTest AND BookTest because the csproj file is important herer
{

    public delegate string WriteLogDelegate(string logMessage); //delegates what a method is supposed to look like
    //Delegates can invoke multiple methods

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage; //Point log to method
            //We are callign Return message twice, first in line 17 and then in like 18 so count goes up two times

            log += IncrementCount; //count goes up a third time

            var result = log("Hello!");
            Assert.Equal("hello!", result); //Increment count made it smaller 
            Assert.Equal(3, count);
        }



        string IncrementCount(string message) //Delegate type still matches
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)  //Method you invoke
        {
            count++;
            return message;
        }


    }
}