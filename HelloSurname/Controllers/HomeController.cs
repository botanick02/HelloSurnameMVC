using HelloSurname.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloSurname.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult HelloName(UserNameInputModel NameInputModel)
        {
            if (ModelState.IsValid)
            {
                return View("HelloName", new IndexViewModel(NameInputModel.Name));
            }
            return View("Index");
        }
    }
}