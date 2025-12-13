using System.ComponentModel.DataAnnotations;

namespace MovieManiaPr02.Models
{
    public class Movie
    {

        public int MovieId { get; set; }


        [Required(ErrorMessage = "Title is required!")]
        [StringLength(100, ErrorMessage = "Title can not be longer than 100 characters!" )]
        public string Title { get; set; } = string.Empty;


        [Required]
        [Range(1888, 2025, ErrorMessage = "Release Year can only be between 1888 and the current year!")]
        public int ReleaseYear { get; set; }

        [Required]
        [Range(1, 500)]
        public int DurationInMinutes { get; set; }

        [StringLength(500, ErrorMessage = "Description can not be longer than 500 characters!")]
        public string? Description { get; set; }

        [Range(1, 10, ErrorMessage = "Rating has to be between 1 and 10!")]
        public int? Rating { get; set; }

    }
}
