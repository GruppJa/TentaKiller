using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TentaKiller
{
    public class Student
    {
        // TODO remove set
        public String Id { get; set; }
        public String Name { get; set; }
        public Student(String id, String name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Student(String name) : this(System.Guid.NewGuid().ToString(), name) { }

        public Student() : this("John Doe") { }
    }
}
