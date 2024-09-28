using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;

public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string? Address { get; set; }
        [Required]
        public string Email { get; set; }
    }
