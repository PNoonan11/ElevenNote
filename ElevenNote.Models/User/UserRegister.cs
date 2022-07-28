using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Models.User
{
    public class UserRegister
    {
        // [Required]
        [EmailAddress]
        public string Email { get; set; }
        //[Required]
        [MinLength(4)]
        public string Username { get; set; }
        // [Required]
        [MinLength(4)]
        public string Password { get; set; }
        // [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}