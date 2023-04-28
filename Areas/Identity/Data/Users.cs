using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Users class
public class Users : IdentityUser
{
    public string Name { get; set; }
    public string LastName { get; set; }
}

