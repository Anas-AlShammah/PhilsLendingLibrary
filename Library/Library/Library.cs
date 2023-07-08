using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : ILibrary
    {
        public int Count => books.Count;

        private Dictionary<string,Book> books;

        public Library()
        {
            books = new Dictionary<string, Book>();
        }
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName, lastName, numberOfPages);
            books.Add(title, book);
        }

        public Book Borrow(string title)
        {
            var book = books.ContainsKey(title);

            if (book) {
               
               
                var ans = books[title];
              
                books.Remove(title);
                return ans;
            }
            return null;
        }

        public void Return(Book book)
        {
            books.Add(book.Title, book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in books.Values)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
