using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKiller.Models
{
    public class Trial
    {
        public String Id { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Student Student { get; set; }
        public DateTime Started { get; set; }
        public DateTime Ended { get; set; }
        public virtual ICollection<TrialPart> Parts { get; set; }

        public Trial() : this(System.Guid.NewGuid().ToString()) { }

        public Trial(String id)
        {
            Id = id;
            Started = DateTime.Now;
            Parts = new HashSet<TrialPart>();
        }
    }
}
