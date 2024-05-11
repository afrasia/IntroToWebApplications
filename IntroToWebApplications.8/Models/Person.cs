using System.ComponentModel.DataAnnotations;

namespace IntroToWebApplications._8.Models
{
    public class Person
    {
        [Required]
        [StringLength(5)]
        public required string FirstName
        {
            get;
            set;
        }

        [Required]
        [StringLength(15)]
        public required string LastName
        {
            get;
            set;
        }
    }
}
