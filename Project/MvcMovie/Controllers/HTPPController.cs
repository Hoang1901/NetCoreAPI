using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.HTPPController
{
    public class HTPPController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public HTPPController(ApplicationDbcontext context)
        {
            _context = context;
        }
    }
}