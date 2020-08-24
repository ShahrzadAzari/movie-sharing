using System.ComponentModel.DataAnnotations;

namespace SharedData
{
    public class RegisterModel
    {

        [Required , RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$" , ErrorMessage="Please enter your firstname starting with capital letter.")]
        [Display(Name = "Firstname")]
        public string Firstname {get;set;}

        [Required , RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$" , ErrorMessage="Please enter your lastname starting with capital letter.")]
        [Display(Name = "Lastname")]
        public string Lastname {get;set;}

        [Required]
        [EmailAddress(ErrorMessage = "Email addresse is invalid.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}