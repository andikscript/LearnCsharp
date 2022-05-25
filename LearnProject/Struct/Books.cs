using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Struct
{
    struct Books
    {
        private string title;
        private string subject;
        private string author;
        private int id;

        public void setBooks(string title, string subject, string author, int id)
        {
            this.title = title;
            this.subject = subject;
            this.author = author;
            this.id = id;
        }

        public (string title, string subject, string author, int id) getBooks()
        {
            return (this.title, this.subject, this.author, this.id);
        }
    }
}
