using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.obj.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Boolean IsCompleted { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}