using App.Core;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.BookEntity.DTOs;

namespace App.Domain.Services.BookEntity
{
    public class BookService : IBookService
    {
        private readonly IBookAppService _bookAppService;
        public BookService(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        public List<BookDTO> GetAll()
        {
            return _bookAppService.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookAppService.GetById(id);
        }
    }
}
