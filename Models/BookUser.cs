using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class BookUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
