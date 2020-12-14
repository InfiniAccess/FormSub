using System.ComponentModel.DataAnnotations;

namespace FormSubmiss.Models
{
    public class FormSub
    {

        [Display(Name = "First Name")]
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        [Required]
        [Range(1, 130)]
        public int Age { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [MinLength(4)]
        public string Password { get; set; }
    }
}