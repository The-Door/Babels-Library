using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Book
    {

        public string title;
        public string author;
        public int pages;
        public bool loan;

        public Book(string aTitle, string aAuthor, int aPages, bool aLoan)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            loan = aLoan;
        }

    }
}
