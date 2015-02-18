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
        public DbSet<Lie> Lies { get; set; }
        public DbSet<Challange> Challanges { get; set; }
        public DbSet<Trial> Trials { get; set; }
        public DbSet<TrialPart> TrialParts { get; set; }

        public override int SaveChanges()
        {
            Console.WriteLine("SaveChanges()");

            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex) // TODO proper handling..
            {
                Console.WriteLine("SAVE CHANGES ERROR : {0}", ex.Message);
            }

            return 0;
        }
    }
}
