using Microsoft.AspNetCore.Identity;

namespace MvcMovie.Models.Entities
{
    public class ApplicationUsers : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}