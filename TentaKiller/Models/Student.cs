using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TentaKiller.Models
{
    public class Student
    {
        // TODO remove set
        public String Id { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Challange> Challanges { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Lie> Lies { get; set; }

        public Student(String id, String name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Student(String name) : this(System.Guid.NewGuid().ToString(), name) { }

        public Student() : this("John Doe") { }
    }
}
