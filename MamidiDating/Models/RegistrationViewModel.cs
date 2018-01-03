using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiDating.Models
{
    public class RegistrationViewModel
    {
        public int RegistrationId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Your password must contain at least 8 characters that consist of an upper-case letter, a lower-case letter, a number, and a symbol.")]
        [Display(Name = "Password")]
        [RegularExpression(@"(?=^.{8,}$)(?=.*\d)(?=.*[!@#$%^&*]+)(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Your password does not meet the requirements.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must confirm your password.")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Your passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "You must select your birth month")]
        [Display(Name = "Month")]
        public string Month { get; set; }

        [Required(ErrorMessage = "You must select your day of birth")]
        [Display(Name = "Day")]
        public string Day { get; set; }

        [Required(ErrorMessage = "You must enter your 4 digit birth year")]
        [Display(Name = "Year (yyyy)")]
        public string Year { get; set; }

        [Required(ErrorMessage = "You must be at least 18 years old.")]
        [Display(Name = "Age")]
        [Range(18, 120)]
        public int Age { get; set; }

        [Required(ErrorMessage = "You must agree to a Background Check.")]
        [Display(Name = "Background Check")]
        public string BackgroundCheck { get; set; }
        public bool IsBackgroundCheck { get; set; }

        public string Salt { get; set; }
    }
}