using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Users.Models
{
    public class AppUser : IdentityUser
    {
        // additional properties will go here
        public int CityID { get; set; }
        public virtual City City { get; set; }
    }
}