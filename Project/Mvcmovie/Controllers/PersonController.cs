using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        public IActionResult PersonIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonIndex(Person ps)
        {
            string strOutput = "Xin chao " + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
        
    }
}
