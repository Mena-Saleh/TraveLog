using System.ComponentModel.DataAnnotations;

namespace TraveLog.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(100, ErrorMessage = "The Name must be between 2 and 100 characters long.", MinimumLength = 2)]
        public string Name { get; set; }

        // Navigation properties
        public ICollection<Destination> Destinations { get; set; }

        public ICollection<ApplicationUser> CountryVisitors { get; set; }

    }
}
