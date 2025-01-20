using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARYBOOKS
{
    internal class Books
    {
        private string title;
        private string author;
        private string bookID;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        Books(string title, string author, string bookID)
        {
            this.title = title;
            this.author = author;
            this.bookID = bookID;
        }

        public void getDetails()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Author);
        }



    }
}
