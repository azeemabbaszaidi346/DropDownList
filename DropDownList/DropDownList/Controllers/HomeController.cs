using DropDownList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DropDownList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ApplicationDbContext DbContext;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext application)
        {
            _logger = logger;
            DbContext = application;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountries()
        {
            var countries = DbContext.Countries.ToList();
            return Json(countries);
        }
        public JsonResult GetStates(int id)
        {
            var states = DbContext.States.Where(e=>e.Country.id== id).ToList();
            return Json(states);
        }
        public JsonResult GetCities(int id)
        {
            var cities = DbContext.Citys.Where(e => e.State.id == id).ToList();
            return Json(cities);
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
