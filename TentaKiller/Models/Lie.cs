using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKiller.Models
{
    public class Lie
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public virtual Student Creator { get; set; }
        public virtual Challange Challange { get; set; }

        public Lie(string id, string lie)
        {
            Id = id;
            Text = lie;
            this.Created = DateTime.Now;
        }

        public Lie() : this(System.Guid.NewGuid().ToString(), "") { }

        public Lie(string lie) : this(System.Guid.NewGuid().ToString(), lie) { }
    }
}
