using Microsoft.AspNetCore.Identity;
namespace TraveLog.Models

{using Microsoft.AspNetCore.Identity;

    public class ApplicationUser:IdentityUser
    {
        // Constructor
        public ApplicationUser()
        {
            VisitedCountries = new List<Country>();
        }
        // Navigation property
        public ICollection<Country> VisitedCountries { get; set; }
    }
}
