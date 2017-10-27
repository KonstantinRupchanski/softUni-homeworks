using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace BookLibraryModification
{
    public class StartUp
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("input.txt");

            Library lib = new Library();
            string l = reader.ReadLine();
            int n = int.Parse(l);

            for (int i = 0; i < n; i++)
            {
                string[] line = reader.ReadLine().Split(' ');
                string title = line[0];
                string author = line[1];
                string publisher = line[2];
                string releaseDate = line[3];
                string ISBN = line[4];
                double price = double.Parse(line[5]);

                Book book = new Book();

                book.Title = title;
                book.Author = author;
                book.Publisher = publisher;
                book.ReleaseDate = DateTime.ParseExact(releaseDate, "d.M.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = ISBN;
                book.Price = price;

                lib.Books.Add(book);
            }

            DateTime date = DateTime.ParseExact(reader.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var books in lib.Books.Where(x => x.ReleaseDate > date).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                File.AppendAllText("output.txt", $"{books.Title} -> {books.ReleaseDate:dd.MM.yyyy}\n");
            }
        }
    }
}
