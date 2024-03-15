using App.Core;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.BookEntity.DTOs;

namespace App.Domain.AppServices.BookEntity
{
    public class BookAppService : IBookAppService
    {
        private readonly IBookRepository _bookRepo;
        public BookAppService(IBookRepository bookRepository)
        {
            _bookRepo = bookRepository;
        }


        public List<BookDTO> GetAll()
        {
            return _bookRepo.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepo.GetById(id);
        }

        public List<Book> NoneBorrowedBooks()
        {
            return _bookRepo.NoneBorrowedBooks();
        }
    }
}
