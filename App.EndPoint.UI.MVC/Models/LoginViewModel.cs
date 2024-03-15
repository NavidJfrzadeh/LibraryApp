using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.MVC.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Emai { get; set; }
        [Required]
        public string Password { get; set; }

        public bool IsAdmin { get; set; } = false;
    }
}
