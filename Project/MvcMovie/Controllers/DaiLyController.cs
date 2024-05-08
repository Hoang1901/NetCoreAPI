using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.EmployeeController
{
    public class DaiLyController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public DaiLyController(ApplicationDbcontext context)
        {
            _context = context;
        }
    }
}