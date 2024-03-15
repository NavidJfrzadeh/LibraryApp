using System.ComponentModel.DataAnnotations;

namespace App.Core.CustomerEntity.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        public List<Book>? BorrowedBooks { get; set; } = new List<Book>();
    }
}
