using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TraveLog.Data;
using TraveLog.Models;
using TraveLog.ViewModels;

namespace TraveLog.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Explore()
        {
            // Get all countries including their destinations
            List<Country> countries = await _db.Countries.Include(c => c.Destinations).ToListAsync();

            return View(countries);
        }

        [Authorize]
        public async Task<IActionResult> Logger()
        {
            // Get user's visited countries
            var user = await _userManager.Users
                .Include(u => u.VisitedCountries)
                .SingleOrDefaultAsync(u => u.Id == _userManager.GetUserId(User));

            if (user == null)
            {
                return NotFound("User not found");
            }
            List<Country> visitedCountries = user.VisitedCountries.ToList();

            // Get avaialble countries
            List<Country> countries = await _db.Countries.ToListAsync();

            // Prepare view model
            LoggerViewModel viewModel = new LoggerViewModel
            {
                AvailableCountries = countries,
                VisitedCountries = visitedCountries
            };
            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> AddCountry([FromBody] string countryName)
        {
            var user = await _userManager.Users
                .Include(u => u.VisitedCountries)
                .SingleOrDefaultAsync(u => u.Id == _userManager.GetUserId(User)); if (user == null) return Unauthorized();

            // Check if the user has already added this country
            if (user.VisitedCountries.Any(c => c.Name == countryName))
            {
                return BadRequest("You have already added this country.");
            }

            var country = GetCountryByName(countryName);
            if (country == null) return NotFound();

            user.VisitedCountries.Add(country);
            await _userManager.UpdateAsync(user);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> RemoveCountry([FromBody] string countryName)
        {
            var user = await _userManager.Users
                            .Include(u => u.VisitedCountries)
                            .SingleOrDefaultAsync(u => u.Id == _userManager.GetUserId(User)); if (user == null) return Unauthorized(); if (user == null) return Unauthorized();

            var country = user.VisitedCountries.FirstOrDefault(c => c.Name == countryName);
            if (country == null)
            {
                return BadRequest("You have not visited this country.");
            }

            user.VisitedCountries.Remove(country);
            await _userManager.UpdateAsync(user);

            return Ok();
        }

        public Country GetCountryByName(string countryName)
        {
            var country = _db.Countries.SingleOrDefault(c => c.Name == countryName);
            return country;
        }


    }
}
