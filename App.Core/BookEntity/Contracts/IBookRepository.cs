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
    }
}
