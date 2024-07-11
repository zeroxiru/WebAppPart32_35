using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppPart32_35.Models;
using WebAppPart32_35.ViewModels;

namespace WebAppPart32_35.Controllers
{

    //[Route("Home")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IEmployee _employee;

        public HomeController(IEmployee employee)
        {
            _employee = employee;
        }
        [HttpGet("~/Home")]
        [HttpGet("~/")]

        [HttpGet("")]      
        //[Route("Index")]
       // [HttpGet("[action]")]

        public ViewResult Index()
        {
            var emplist = _employee.GetAllEmployees();
            ViewBag.PageTitle = "Employee List";

            return View(emplist);
        }
        //[Route("Details/{id?}")]
        [HttpGet("{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employee.GetEmployee(id??1),
                PageTitle = "Employee Deatils"
            };

            return View(homeDetailsViewModel);

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

