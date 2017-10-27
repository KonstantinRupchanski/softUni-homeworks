using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookLibrary
{
    public class StartUp
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("input.txt");

            Library lib = new Library();

            int n = int.Parse(reader.ReadLine());

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
                book.ReleaseDate = releaseDate;
                book.ISBN = ISBN;
                book.Price = price;

                lib.Books.Add(book);
            }

            List<string> publishers = new List<string>();

            var res = lib.Books.GroupBy(x => x.Author).ToDictionary(x => x.Key, x => x.Select(c => c.Price).Sum());

            foreach (var author in res.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                File.AppendAllText("output.txt", $"{author.Key} -> {author.Value:f2}\n");
            }
        }
    }
}