using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Person
    {
        [Key]
        [Required]
        public string PersonID { get; set; }
        public string HoTen { get; set; }
        public string? QueQuan { get; set; }
    }
}