using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 
        public IActionResult EmployeeIndex()
        {
            return View();
        } 
        
    }
}
