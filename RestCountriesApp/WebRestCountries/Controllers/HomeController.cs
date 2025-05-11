using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestCountriesAPI;
using System.Diagnostics;
using WebRestCountries.Models;

namespace WebRestCountries.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CountryService _countryService;

        public HomeController(ILogger<HomeController> logger, CountryService countryService)
        {
            _logger = logger;
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var countries = await _countryService.GetAllCountriesAsync();
            ViewBag.Countries = new SelectList(countries, "Cca3", "NombreVisible"); // O "Name.Official"
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string cca3)
        {
            var countries = await _countryService.GetAllCountriesAsync();
            var selected = countries.FirstOrDefault(c => c.Cca3 == cca3);
            ViewBag.Countries = new SelectList(countries, "Cca3", "NombreVisible", cca3);
            return View(selected);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
