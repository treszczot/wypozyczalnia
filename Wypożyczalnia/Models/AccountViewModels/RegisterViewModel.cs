using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }
        [Required]
        [Display(Name ="Numer telefonu")]
        public string PhoneNumber { get; set; }
        public bool isAdmin { get; set; }
    }
}
