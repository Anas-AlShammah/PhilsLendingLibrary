using Library;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Library.Library library = new Library.Library();
            Book booktest = new Book("1984", "George", "Orwell", 328);
            library.Add("1984", "George", "Orwell", 328);

            bool containsBook = false;
            foreach (var book in library)
            {
                if (book.Title == booktest.Title )
                {
                    containsBook = true;
                    break;
                }
            }

            Assert.True(containsBook);
            Assert.Equal(1, library.Count);
        }
        [Fact]
        public void Test2()
        {
            Library.Library library = new Library.Library();
            Book booktest = new Book("1984", "George", "Orwell", 328);
            library.Add("1984", "George", "Orwell", 328);
            library.Add("The Great Gatsby", "F. Scott", "Fitzgerald", 218);
            library.Add("To Kill a Mockingbird", "Harper", "Lee", 281);
            var count = library.Count;
            library.Borrow("1984");
            bool containsBook = false;
            foreach (var book in library)
            {
                if (book.Title == booktest.Title )
                {
                    containsBook = true;
                    break;
                }
            }
            Assert.False(containsBook);
            Assert.Equal(count-1, library.Count);
        }
        [Fact]
        public void Test3()
        {
            Library.Library library = new Library.Library();
            Book booktest = new Book("1984", "George", "Orwell", 328);
            library.Add("The Great Gatsby", "F. Scott", "Fitzgerald", 218);
            library.Add("To Kill a Mockingbird", "Harper", "Lee", 281);
            var count = library.Count;
            var brrow=library.Borrow("1984");
            Assert.Null(brrow);
            Assert.Equal(count, library.Count);

        }
        [Fact]
        public void Test4()
        {
            Library.Library library = new Library.Library();
            Book booktest = new Book("1984", "George", "Orwell", 328);
            library.Add("1984", "George", "Orwell", 328);
            library.Add("The Great Gatsby", "F. Scott", "Fitzgerald", 218);
            library.Add("To Kill a Mockingbird", "Harper", "Lee", 281);
           
            library.Borrow("1984");
            var count = library.Count;
            library.Return(booktest);
            Assert.Equal(count+1 , library.Count);

        }
        [Fact]
           public void Test5()
            {
            // Arrange
            Backpack<string> backpack = new Backpack<string>();

            // Act
            backpack.Pack("Anas");
            backpack.Pack("Bassam");
            backpack.Pack("AL-Shammah");

            string unpackedItem2 = backpack.Unpack(1);

            // Assert
            Assert.Equal(2, backpack.Count);
            Assert.Contains("Anas", backpack);
            Assert.Contains("AL-Shammah", backpack);
            Assert.Equal("Bassam", unpackedItem2);
        }
    }
}