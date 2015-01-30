using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKiller
{
    public class Challange
    {
        public String Id { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
        public List<String> Lies { get; set; }

        public Challange()
        {
            this.Lies = new List<String>();
        }
    }
}