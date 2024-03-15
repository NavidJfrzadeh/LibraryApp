using App.Domain.Core.AdminEntity.Contracts;
using App.Domain.Core.AdminEntity.Entities;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.BookEntity.DTOs;

namespace App.Domain.AppServices.AdminEntity
{
    public class AdminAppService : IAdminAppService
    {
        private readonly IBookRepository _bookRepo;
        private readonly IAdminRepository _adminRepo;
        public AdminAppService(IBookRepository bookRepo, IAdminRepository adminRepo)
        {
            _bookRepo = bookRepo;
            _adminRepo = adminRepo;
        }


        public void AddNewBook(BookDTO bookModel)
        {
            _bookRepo.AddBook(bookModel);
        }


        public Admin CheckLogin(string Email, string Password)
        {
            var targetAdmin = _adminRepo.GetAll().FirstOrDefault(a=>a.Email == Email && a.Password == Password);
            return targetAdmin;
        }

        public void RemoveBook(int id)
        {
            _bookRepo.RemoveBook(id);
        }
    }
}