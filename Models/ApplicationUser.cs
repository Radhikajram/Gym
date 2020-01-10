using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class ApplicationUser : IdentityUser
    {
       // public int Id { get; set; }
        // Navigation Property

        public virtual ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }

   
}
