using Microsoft.AspNetCore.Mvc;

namespace Demo.Cotroller;
public class DemoController : Controller
{
    //khai bao cac action
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Fullname)
    {
        string strResult = "Xin chao " +Fullname;
        ViewBag.info = strResult;
        return View();
    }
}