using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.Data.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime lastLogin { get; set; } 

    }
}
