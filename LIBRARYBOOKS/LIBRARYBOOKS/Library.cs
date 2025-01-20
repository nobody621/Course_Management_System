using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARYBOOKS
{
    internal class Library
    {
        private Books books;

        public Books Books
        {
            get { return books; }
            set { books = value; }
        }

        Library(Books books)
        {
            this.books = books;
        }
    }
}
