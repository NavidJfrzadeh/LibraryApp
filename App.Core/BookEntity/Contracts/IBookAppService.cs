using App.Core;
using App.Domain.Core.BookEntity.DTOs;

namespace App.Domain.Core.BookEntity.Contracts
{
    public interface IBookAppService
    {
        public List<BookDTO> GetAll();
        public Book GetById(int id);
        public List<Book> NoneBorrowedBooks();
    }
}
