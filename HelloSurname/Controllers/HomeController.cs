using HelloSurname.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloSurname.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}