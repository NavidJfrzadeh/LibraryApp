using App.Core;
using App.Core.CustomerEntity.Entities;

namespace App.Domain.Core.CustomerEntity.Contracts
{
    public interface ICustomerService
    {
        public Customer CheckLogin(string Email, string Password);
        public void BorrowBook(int BookId, int userId);
        public void ReturnBook(int bookId, int userId);
        public List<Book> CustomerBooks(int CustomerId);
    }
}