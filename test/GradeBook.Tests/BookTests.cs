using System;
using Xunit;
//test with dotnet test
namespace GradeBook.Tests //CREATE A SOLUTION FILE WITH: cd to gradebook and then "dotnet new sln" and then "dotnet add src\GradeBook\GradeBook.csproj" and the GradeBook.Test.csproj File
{
    public class BookTests //These are all Unit tests. An integration test looks quite similar to an Unit test but there is more setup and so
    //For Integration tests its more important to really figure out what is setup and what is test so you an abstract the setup away and not repeat yourself all the time
    //When you set up a temporary test-database dont forget to drop it to save space
    {

        /*      [Fact]
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
              }*/

        [Fact]
        public void TestException_TooHigh()
        {
            var book = new InMemoryBook("name");
            Assert.Throws<ArgumentException>(() => book.AddGrade(8.1)); //Test exceptions!! :D
        }

        [Fact]
        public void TestAverage()
        {
            // arrange
            var book = new InMemoryBook("name");
            book.AddGrade(5.1);
            book.AddGrade(4.1);
            book.AddGrade(3.1);

            var result = book.GetStatistics();

            Assert.Equal(4.1, result.Average);


        }
        [Fact] //Dont forget Fact if you want to test
        public void TestHigh()
        {
            // arrange
            var book = new InMemoryBook("name");
            book.AddGrade(5.1);
            book.AddGrade(4.1);
            book.AddGrade(3.1);

            var result = book.GetStatistics();

            Assert.Equal(5.1, result.High);


        }

        [Fact] //Dont forget Fact if you want to test
        public void TestChangeNameFromValue()
        {
            // arrange
            var bookoldname = new InMemoryBook("name");
            bookoldname.Bookname = "newname";


            Assert.Equal("newname", bookoldname.Bookname);

        }

        [Fact] //Dont forget Fact if you want to test
        public void TestAuthors()
        {
            // arrange
            var authorbook = new InMemoryBook("name");

            authorbook.AddAuthor("Manchester");
            authorbook.AddAuthor("United");

            Assert.Equal("These are the Authors: Manchester, United", authorbook.AllAuthors());
        }
        [Fact] //Dont forget Fact if you want to test
        public void TestTwoVarsSameObject()
        {
            // arrange
            var book1 = new InMemoryBook("name");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));


        }
        [Fact] //Dont forget Fact if you want to test
        public void TestTwoVarsDifferentObject()
        {
            // arrange
            var book1 = new InMemoryBook("name");
            var book2 = new InMemoryBook("name");

            Assert.NotSame(book1, book2);


        }

        [Fact] //Dont forget Fact if you want to test
        public void TestChangeNameFalseforCopy()
        {
            // arrange
            var book1 = new InMemoryBook("name");
            var book2 = new InMemoryBook("Lame Name");
            
            GetBookSetName(book1, "New Name");
            GetBookSetNamebyRef(ref book2, "New Name"); // make it clear you want to pass by refrence with ref
            
            
            Assert.NotEqual("New Name", book1.Bookname);
            Assert.Equal("New Name", book2.Bookname);


        }
        [Fact] //Dont forget Fact if you want to test
        public void TestLoop()
        {
            // arrange
            var booke = new InMemoryBook("name");
            booke.AddGrade(5.1);
            booke.AddGrade(4.1);
            booke.AddGrade(3.1);

            var result = booke.LoopMe();
            int first = result[0];
            Assert.Equal(0, first); //"WHILE BIGGERTHAN includes the the number you want to be bigger than (when you count down)
            int second = result[1];
            Assert.Equal(4, second); //but when you count up it does not!
            int third = result[2];
            Assert.Equal(69, third); //This test could POTENTIALLY fail, if the probability allows it to$
            //Who needs russian roulette when you're a programmer, am I right fellas??



        }

        [Fact] //Dont forget Fact if you want to test
        public void TestLetter()
        {
            // arrange
            var booke = new InMemoryBook("name");
            booke.AddGrade(5.1);
            booke.AddGrade(4.1);
            booke.AddGrade(3.1);

            var stats = booke.GetStatistics();

            Assert.Equal('C', stats.Letter);
        }

        private void GetBookSetName(InMemoryBook book1, string name) //Copies book, does not change original
        {
            book1 = new InMemoryBook(name); //new reference
        }

        private void GetBookSetNamebyRef(ref InMemoryBook book, string newname) //Pass by reference
        {
            book = new InMemoryBook(newname);
        }

        /*
        Important: Strings are refernece types but behave like value types
        Return copies of strings, not refrences
        Strings are immutable
        */
    }

}
