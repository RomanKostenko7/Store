using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-32131", "D. Knuth", "Art Of Programming", "nice book", 5m),
            new Book(2, "ISBN 12312-32132", "M. Knuth", "Refactoring", "nice book", 10m),
            new Book(3, "ISBN 12312-32133", "B. Knuth", "C Programming Language", "nice book", 15m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                                    .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}