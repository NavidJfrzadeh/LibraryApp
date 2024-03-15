using App.Core.CustomerEntity.Entities;
using App.Domain.Core.AdminEntity.Entities;

namespace App.Infra.DataBase.MemoryDataBase
{
    public static class MemoryDataBase
    {
        public static Customer? ActiveCustomer { get; set; }
        public static Admin? ActiveAdmin { get; set; }
    }
}
