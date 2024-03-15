using App.Core;
using App.Domain.Core.BookEntity.DTOs;

namespace App.Domain.Core.BookEntity.Contracts
{
    public interface IBookRepository
    {
        public List<BookDTO> GetAll();
        public Book GetById(int id);
        public void AddBook(BookDTO bookModel);
        public void RemoveBook(int id);
        public List<Book> NoneBorrowedBooks();
        public bool UpdateBook(int bookId,int UserID);
        public List<Book> CustomerBooks(int CustomerId);
        public void ReturnBook(int bookId);
    }
}
