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
    }
}
