using App.Domain.Core.AdminEntity.Contracts;
using App.Infra.DataBase.SQLServer.EF;

namespace App.Infra.Data.Repo.EF.Admin
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext _context;
        public AdminRepository()
        {
            _context = new AppDbContext();
        }


        public List<Domain.Core.AdminEntity.Entities.Admin> GetAll()
        {
            var admins = _context.admins.ToList();
            return admins;
        }
    }
}
