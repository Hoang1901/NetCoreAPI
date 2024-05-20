using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.HTPPController
{
    public class HTPPController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HTPPController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}