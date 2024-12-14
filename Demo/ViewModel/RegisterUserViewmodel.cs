using System.ComponentModel.DataAnnotations;

namespace Demo.ViewModel
{
    public class RegisterUserViewmodel 
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirmpassword { get; set; }
        [Required]

        public string Address { get; set; }

    }
}
