
namespace MvcMovie.Models;

public class Employee : Person
{
    public required string EmployeeId { get; set; }
    public string? company { get; set; }
}