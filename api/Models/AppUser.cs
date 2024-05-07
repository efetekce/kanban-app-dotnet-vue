using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace api.Models
{
    public class AppUser : IdentityUser
    {
        // public int Id { get; set; }
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        // public string Email { get; set; }
        // public string UserName { get; set; }
        // public string Password { get; set; }

        public int? TeamId { get; set; }

        public Team? Team { get; set; }

        // todos created by this specific user
        public List<Todo> Todos { get; set; }
    }
}