using System.ComponentModel.DataAnnotations;

namespace PowerPlaner.MVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Potwierdź hasło")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasło i potwierdzenie hasła nie pasują.")]
        public string ConfirmPassword { get; set; }
    }
}
