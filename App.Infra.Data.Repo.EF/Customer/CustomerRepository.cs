using App.Core;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.CustomerEntity.Contracts;
using App.Infra.DataBase.SQLServer.EF;

namespace App.Infra.Data.Repo.EF.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository()
        {
            _context = new AppDbContext();
        }

        public bool BorrowBook(Book book, int userId)
        {
            var targetUser = GetById(userId);
            if (targetUser != null)
            {
                targetUser.BorrowedBooks.Add(book);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Core.CustomerEntity.Entities.Customer> GetAll()
        {
            var customers = _context.customers.ToList();
            return customers;
        }

        public Core.CustomerEntity.Entities.Customer GetById(int id)
        {
            var targetCustomer = _context.customers.FirstOrDefault(c => c.Id == id);
            return targetCustomer ?? null;
        }

        public bool ReturnBook(int userID, Book book)
        {
            var customer = _context.customers.FirstOrDefault(c=>c.Id == userID);
            if (customer != null)
            {
                customer.BorrowedBooks.Remove(book);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
