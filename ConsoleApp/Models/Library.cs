using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Library
    {
        List<Book> BooksList { get; set; }

        public Library()
        {
            BooksList = new List<Book>();
        }

        public void Add(Book bookToAdd)
        {
            BooksList.Add(bookToAdd);
        }

        public void ShowBooks()
        {
            foreach (var book in BooksList)
            {
                Console.WriteLine(book.Info());
            }
        }
    }
}
