using System.ComponentModel.DataAnnotations;

namespace PaloItChallenge.Models
{
    public class FullName
    {
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
    }
}