using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.EmployeeController
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public EmployeeController(ApplicationDbcontext context)
        {
            _context = context;
        }
    }
}