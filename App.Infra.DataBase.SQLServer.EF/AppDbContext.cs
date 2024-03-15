using App.Core;
using App.Core.CustomerEntity.Entities;
using App.Domain.Core.AdminEntity.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.DataBase.SQLServer.EF
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CW21;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerEntityConfig());
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Customer)
                .WithMany(c => c.BorrowedBooks)
                .HasForeignKey(b => b.CustomerId)
                .OnDelete(DeleteBehavior.SetNull).IsRequired(false);
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
