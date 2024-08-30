using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        public IActionResult PersonIndex()
        {
            return View();
        } 
        
    }
}
