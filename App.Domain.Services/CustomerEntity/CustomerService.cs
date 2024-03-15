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
        public Customer CheckLogin(string Email, string Password)
        {
            return _customerAdppService.CheckLogin(Email, Password);
        }
    }
}