using System.ComponentModel.DataAnnotations;

namespace Demo.ViewModel
{
    public class Loginuserviewmodel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RemmberME { get; set; }
    }
}
