using App.Core;
using App.Core.CustomerEntity.Entities;

namespace App.Domain.Core.CustomerEntity.Contracts
{
    public interface ICustomerRepository
    {
        public Customer GetById(int id);
        public List<Customer> GetAll();
        public bool BorrowBook(Book book, int userId);
        public bool ReturnBook(int userID, Book book);
    }
}
