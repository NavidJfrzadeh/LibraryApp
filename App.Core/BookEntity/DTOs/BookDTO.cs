using App.Core.CustomerEntity.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.BookEntity.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string AuthorName { get; set; }
        [Required]
        public decimal  Price { get; set; }
    }
}
