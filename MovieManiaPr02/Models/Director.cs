using System.ComponentModel.DataAnnotations;

namespace MovieManiaPr02.Models
{
    public class Director
    {
        public int DirectorId { get; set; }


        [Required]
        [StringLength(200, ErrorMessage = "FirstName can not be longer than 200 characters!")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "LastName can not be longer than 200 characters!")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";


    }
}
