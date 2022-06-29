using System;
using Xunit;
//test with dotnet test
namespace GradeBook.Tests
{    
    public class BookTests
    {

               [Fact]
        public void TestWrongInput()
        {
            // arrange
            var book = new Book("name");
            book.AddGrade(8.1);//ZU HOCH
            book.AddGrade(1.0);
            book.AddGrade(0.4);//ZU TIEF
            

            // act
            var result = book.GetStatistics();//vergiss die klammern nicht!!
    
            // assert
            Assert.NotEqual(8.1, result.High);
            Assert.NotEqual(0.4, result.Low);
                }

        [Fact]
        public void TestAverage()
        {
            // arrange
            var book = new Book("name");
            book.AddGrade(5.1);
            book.AddGrade(4.1);
            book.AddGrade(3.1);

            var result = book.GetStatistics();

            Assert.Equal(4.1,result.Average);
                     
        
        }
       [Fact] //Dont forget Fact if you want to test
            public void TestHigh()
        {
            // arrange
            var book = new Book("name");
            book.AddGrade(5.1);
            book.AddGrade(4.1);
            book.AddGrade(3.1);

            var result = book.GetStatistics();

            Assert.Equal(5.1,result.High);
                     
        
        }

            [Fact] //Dont forget Fact if you want to test
            public void TestTwoVarsSameObject()
        {
            // arrange
            var book1 = new Book("name");
            var book2 = book1;

            Assert.Same(book1,book2);
                     
        
        }
              [Fact] //Dont forget Fact if you want to test
            public void TestTwoVarsDifferentObject()
        {
            // arrange
            var book1 = new Book("name");
            var book2 = new Book ("name");

            Assert.NotSame(book1,book2);
                     
        
        }
    }
}
