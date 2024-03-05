using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Restaurant.Models;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QueryFactory db;
        private readonly IConfiguration _configuration;
        public string getConnectionString { get { return _configuration.GetConnectionString("MSSqlConnection"); } }
        public HomeController(ILogger<HomeController> logger, QueryFactory db, IConfiguration configuration)
        {
            _logger = logger;
            this.db = db;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
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
