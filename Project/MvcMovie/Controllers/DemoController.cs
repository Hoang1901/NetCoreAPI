using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace Demo.Cotroller;
public class DemoController : Controller
{
    //khai bao cac action
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Fullname, string PersonID, string Address)
    {
        string strResult = "Xin chao" + PersonID + "-" + Fullname + "-" + Address;
        ViewBag.info = strResult;
        return View();
    }
}