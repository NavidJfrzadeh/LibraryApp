using App.Core;
using App.Core.CustomerEntity.Entities;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.CustomerEntity.Contracts;

namespace App.Domain.AppServices.CustomerEntity
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IBookRepository _bookRepository;
        public CustomerAppService(ICustomerRepository customerRepository, IBookRepository bookRepository)
        {
            _customerRepo = customerRepository;
            _bookRepository = bookRepository;
        }

        public void BorrowBook(int BookId, int userId)
        {
            var book = _bookRepository.NoneBorrowedBooks().FirstOrDefault(b => b.Id == BookId);
            if (book != null)
            {
                var check = _customerRepo.BorrowBook(book, userId);
                if (check)
                {
                    _bookRepository.UpdateBook(BookId, userId);
                }
            }
        }

        public Customer CheckLogin(string Email, string Password)
        {
            var customer = _customerRepo.GetAll().FirstOrDefault(c => c.Email == Email && c.Password == Password);
            return customer ?? null;
        }

        public List<Book> CustomerBooks(int CustomerId)
        {
            return _bookRepository.CustomerBooks(CustomerId);
        }

        public void ReturnBook(int bookId, int userId)
        {
            var book = _bookRepository.GetById(bookId);
            if(book != null)
            {
                var check = _customerRepo.ReturnBook(userId, book);
                if (check)
                {
                    _bookRepository.ReturnBook(bookId);
                }
            }
        }
    }
}
