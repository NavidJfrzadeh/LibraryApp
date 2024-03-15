using App.Domain.Core.AdminEntity.Entities;

namespace App.Domain.Core.AdminEntity.Contracts
{
    public interface IAdminRepository
    {
        public List<Admin> GetAll();
    }
}
