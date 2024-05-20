using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.EmployeeController
{
    public class DaiLyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DaiLyController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}