using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.ASPDotNETCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.ASPDotNETCore.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Enter required fields");
            //Write your Insert code here;
            return this.Ok($"Form Data received!");            
        }

        public IActionResult CreateStudent1()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] StudentModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Enter required fields");
            //Insert code;
            return this.Ok($"Form Data received!");
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
