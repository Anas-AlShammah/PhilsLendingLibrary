using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int NumberOfPage { get; set; }
        public Book(string title, string firstName, string lastName,int number)
        {
            Title=title;
            FirstName=firstName;
            LastName=lastName;
            NumberOfPage=number;
        }
    }
}
