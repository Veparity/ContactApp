using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApp.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50,ErrorMessage ="The {0} must be at least {2} and max {1} characters long.")]
        public string? FirstName {get;set;}
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and max {1} characters long.")]
        public string? LastName {get;set;}
        [NotMapped]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }


        //Todo: Make relationship to Contact Model
        //Todo: Make relationship to Category Model

    }
}
