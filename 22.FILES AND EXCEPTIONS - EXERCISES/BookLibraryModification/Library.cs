using System.Collections.Generic;

namespace BookLibraryModification
{
    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public Library()
        {
            this.Name = "name";
            this.Books = new List<Book>();
        }
    }
}
