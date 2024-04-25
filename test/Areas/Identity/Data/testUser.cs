using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace test.Areas.Identity.Data;

// Add profile data for application users by adding properties to the testUser class
public class testUser : IdentityUser
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public DateTime lastLogin { get; set; } = DateTime.UtcNow.AddHours(3);
    public bool IsBlocked { get; set; } = false;
}

