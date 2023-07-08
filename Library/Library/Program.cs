namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.Add("The Great Gatsby", "F. Scott", "Fitzgerald", 218);
            lib.Add("To Kill a Mockingbird", "Harper", "Lee", 281);
            lib.Add("1984", "George", "Orwell", 328);
            Book booktest = new Book("1984", "George", "Orwell", 328);
            lib.Add("Pride and Prejudice", "Jane", "Austen", 432);
            var book =lib.Borrow("1984");
            lib.Return(booktest);


        }
    }
}