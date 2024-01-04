using Microsoft.AspNetCore.Identity;

namespace Design_A_Bear.DataAccess
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
