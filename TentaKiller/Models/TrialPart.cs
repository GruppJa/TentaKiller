using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKiller.Models
{
    public class TrialPart
    {
        public String Id { get; set; }
        public String Answer { get; set; }
        public int Points { get; set; }
        public virtual Trial Trial { get; set; }
        public virtual Challange Challange { get; set; }
        public TrialPart() : this(System.Guid.NewGuid().ToString()) { }

        public TrialPart(String id)
        {
            Id = id;
            Points = 1;
        }
    }
}
