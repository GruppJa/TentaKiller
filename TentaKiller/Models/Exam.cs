﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKiller.Models
{
    public class Exam
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Challange> Challanges { get; set; }

        public Exam(String id, String name)
        {
            this.Id = id;
            this.Name = name;
            this.Challanges = new HashSet<Challange>();
        }

        public Exam() : this(System.Guid.NewGuid().ToString(), "New Exam") { }
    }
}
