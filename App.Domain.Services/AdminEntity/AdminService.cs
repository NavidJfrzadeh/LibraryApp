using App.Domain.Core.AdminEntity.Contracts;
using App.Domain.Core.AdminEntity.Entities;
using App.Domain.Core.BookEntity.DTOs;

namespace App.Domain.Services.AdminEntity
{
    public class AdminService : IAdminService
    {
        private readonly IAdminAppService _adminAppServuce;

        public AdminService(IAdminAppService adminAppService)
        {
            _adminAppServuce = adminAppService;
        }


        public void AddNewBook(BookDTO bookModel)
        {
            _adminAppServuce.AddNewBook(bookModel);
        }

        public Admin CheckLogin(string Email, string Password)
        {
            return _adminAppServuce.CheckLogin(Email, Password);
        }
        public void RemoveBook(int id)
        {
            _adminAppServuce.RemoveBook(id);
        }
    }
}