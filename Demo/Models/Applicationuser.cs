using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Applicationuser:IdentityUser
    {
        [Required]
        public string Address { get; set; }
    }
}
