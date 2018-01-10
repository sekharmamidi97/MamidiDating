using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiDating.Models
{
    public class UsernameSearchViewModel
    {
        public int UsernameId { get; set; }
        public int RegistrationId { get; set; }

        [Display(Name = "User Name")]
        public string Username { get; set; }
    }
}