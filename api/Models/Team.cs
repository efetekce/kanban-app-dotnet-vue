using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.obj.Models
{
    public class Team
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<User> Users { get; set; }
    }
}