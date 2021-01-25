using System.ComponentModel.DataAnnotations;

namespace IntroToWebApps5.Core5.Models
{
    public class Person
    {
        [Required]
        [StringLength(5)]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [StringLength(15)]
        public string LastName
        {
            get;
            set;
        }
    }
}
