using App.Core;
using App.Core.CustomerEntity.Entities;
using App.Domain.Core.CustomerEntity.Contracts;

namespace App.Domain.Services.CustomerEntity
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerAppService _customerAdppService;
        public CustomerService(ICustomerAppService customerAppService)
        {
            _customerAdppService = customerAppService;
        }

        public void BorrowBook(int bookId, int UserId)
        {
            _customerAdppService.BorrowBook(bookId, UserId);
        }

        public Customer CheckLogin(string Email, string Password)
        {
            return _customerAdppService.CheckLogin(Email, Password);
        }

        public List<Book> CustomerBooks(int CustomerId)
        {
            return _customerAdppService.CustomerBooks(CustomerId);
        }

        public void ReturnBook(int bookId, int userId)
        {
            _customerAdppService.ReturnBook(bookId, userId);
        }
    }
}