using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
    }

    
}