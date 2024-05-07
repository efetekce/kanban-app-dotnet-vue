using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.obj.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<AppUser> AppUsers { get; set; }
        public List<Todo> Todos { get; set; }
    }
}