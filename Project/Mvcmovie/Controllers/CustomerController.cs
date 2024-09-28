using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class CustomerController : Controller
    {
        private readonly  ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var model = await _context.Customer.ToListAsync();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FullName,Address")]Customer cus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cus);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CustomerId,FullName,Address")]Customer cus)
        {
            if (id != cus.CustomerId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try 
                {
                    _context.Update(cus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(cus.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cus);
        }

        public async Task<IActionResult> Delete (string id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }
            var cus = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerId == id);
            if (cus == null)
            {
                return NotFound();
            }
            return View(cus);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Customer == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Customer' is null");
            }
            var cus = await _context.Customer.FindAsync(id);
            if (cus != null)
            {
                _context.Customer.Remove(cus);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool CustomerExists(string id)
        {
            return _context.Person.Any(e => e.PersonId == id);
        }
    }
}