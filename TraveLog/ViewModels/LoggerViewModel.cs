using TraveLog.Models;

namespace TraveLog.ViewModels
{
    public class LoggerViewModel
    {
        public ICollection<Country> VisitedCountries { get; set; }
        public ICollection<Country> AvailableCountries { get; set; }
    }
}
