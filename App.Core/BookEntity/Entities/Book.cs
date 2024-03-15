using App.Core.CustomerEntity.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.Core
{
    public class Book
    {
        public Book()
        {
            IsActive = true;
            IsBorrowd = false;
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string AuthorName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public bool IsActive { get; set; }
        public bool IsBorrowd { get; set; }
    }
}
