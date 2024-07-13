using System.ComponentModel.DataAnnotations;

namespace TraveLog.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(100, ErrorMessage = "The Name must be between 2 and 100 characters long.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        [StringLength(500, ErrorMessage = "The Description must be between 10 and 500 characters long.", MinimumLength = 10)]
        public string Description { get; set; }

        // Foreign key
        [Required(ErrorMessage = "The CountryId field is required.")]
        public int CountryId { get; set; }

        // Navigation property
        public Country Country { get; set; }

        [Required(ErrorMessage = "The Image URL field is required.")]
        [Url(ErrorMessage = "The Image URL is not valid.")]
        public string ImageUrl { get; set; }

    }
}
