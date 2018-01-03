using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiDating.Models
{
    public class ContactViewModel
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "You must include your first name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must include your last name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must include your username.")]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must include your email address.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "You must select a contact reason.")]
        [Display(Name = "Contact Reason")]
        public string ContactReason { get; set; }

        [Display(Name = "If other, please specify")]
        public string OtherSpecified { get; set; }

        [Required(ErrorMessage = "The Message field is required.")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}