using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace api.Models
{
    public class AppUser : IdentityUser
    {
        public int? TeamId { get; set; }

        public Team? Team { get; set; }
        public List<Todo> Todos { get; set; }
        // todos created by this specific user
    }
}