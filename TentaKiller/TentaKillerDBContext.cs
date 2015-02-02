using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TentaKiller.Models;

namespace TentaKiller
{
    public class TentaKillerDBContext : DbContext
    {
        public TentaKillerDBContext() : base("name=TentaKillerDBConnectionString") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Challange> Challanges { get; set; }
    }
}
