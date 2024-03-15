using App.Core.CustomerEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.DataBase.SQLServer.EF
{
    public class CustomerEntityConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.BorrowedBooks)
                .WithOne(b => b.Customer)
                .HasForeignKey(b => b.CustomerId);
        }
    }
}