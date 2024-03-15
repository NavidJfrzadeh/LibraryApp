using App.Core.CustomerEntity.Entities;
using App.Domain.Core.CustomerEntity.Contracts;

namespace App.Domain.AppServices.CustomerEntity
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepo;
        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }


        public Customer CheckLogin(string Email, string Password)
        {
            var customer = _customerRepo.GetAll().FirstOrDefault(c => c.Email == Email && c.Password == Password);
            return customer ?? null;
        }
    }
}
