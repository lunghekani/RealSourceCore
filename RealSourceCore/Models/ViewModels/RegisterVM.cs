using System.ComponentModel.DataAnnotations;

namespace RealSourceCore.Models.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; }    
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="the password and confirm password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
