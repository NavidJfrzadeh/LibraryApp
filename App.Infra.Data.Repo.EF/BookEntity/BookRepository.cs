using App.Core;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.BookEntity.DTOs;
using App.Infra.DataBase.SQLServer.EF;

namespace App.Infra.Data.Repo.EF.BookEntity
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository()
        {
            _context = new AppDbContext();
        }

        public void AddBook(BookDTO bookModel)
        {
            var newBook = new Book()
            {
                Title = bookModel.Title,
                AuthorName = bookModel.AuthorName,
                Price = bookModel.Price,
            };
            _context.books.Add(newBook);
            _context.SaveChanges();
        }

        public List<BookDTO> GetAll()
        {
            var books = _context.books.Select(b => new BookDTO()
            {
                Id = b.Id,
                Title = b.Title,
                AuthorName = b.AuthorName,
                Price = b.Price
            });

            return books.ToList();
        }

        public Book GetById(int id)
        {
            var targetBook = _context.books.FirstOrDefault(b => b.Id == id);
            return targetBook ?? null;
        }

        public void RemoveBook(int id)
        {
            var targetBook = GetById(id);
            _context.books.Remove(targetBook);
            _context.SaveChanges();
        }
    }
}
