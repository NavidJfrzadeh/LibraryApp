using App.Domain.Core.AdminEntity.Entities;
using App.Domain.Core.BookEntity.DTOs;

namespace App.Domain.Core.AdminEntity.Contracts
{
    public interface IAdminService
    {
        public void AddNewBook(BookDTO bookModel);
        public void RemoveBook(int id);
        public Admin CheckLogin(string Email, string Password);
    }
}