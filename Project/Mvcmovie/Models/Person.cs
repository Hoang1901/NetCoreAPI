using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Person
    {
        [Key]
        public required string PersonID { get; set; }
        public required string HoTen { get; set; }
        public string? QueQuan { get; set; }
    }
}