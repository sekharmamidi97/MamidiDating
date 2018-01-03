using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiDating.Models
{
    public class MessageViewModel
    {
        public int MessageId { get; set; }
        public int RegistrationId { get; set; }

        [Required(ErrorMessage = "You must include the other person's username.")]
        [Display(Name = "To")]
        public string ToUsername { get; set; }

        [Required(ErrorMessage = "You must include the subject of the message.")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "You must include the message")]
        [Display(Name = "Message")]
        public string Message { get; set; }

        [Required(ErrorMessage = "You must include your username.")]
        [Display(Name = "From")]
        public string FromUsername { get; set; }
    }
}