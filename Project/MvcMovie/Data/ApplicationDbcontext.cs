using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        // Khai báo ánh xạ vào trong DataBase
        public DbSet<Person> Person {get; set;}
        public DbSet<Employee> Employees {get; set;}
        public DbSet<HTPP> HTPP {get; set;}
        public DbSet<DaiLy> DaiLy {get; set;}
    }
}