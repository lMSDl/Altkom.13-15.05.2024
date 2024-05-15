using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public Person Author { get; set; }

        public string Info()
        {
            return $"{Title}, Autor: {Author.GetName()} {Author.LastName}";
        }
    }
}
