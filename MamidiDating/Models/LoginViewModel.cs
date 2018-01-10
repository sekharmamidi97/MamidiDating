using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiDating.Models
{
    public class LoginViewModel
    {
        public int LoginId { get; set; }
        public int RegistrationId { get; set; }

        [Required(ErrorMessage = "Your username is required.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Your password is required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

        public string Salt { get; set; }
    }
}