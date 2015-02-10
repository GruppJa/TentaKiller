using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKiller.Models
{
    public class Challange
    {
        public String Id { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
        public List<String> Lies { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

        public Challange(String id, String question, String answer, List<String> lies)
        {
            this.Id = id;
            this.Question = question;
            this.Answer = answer;
            this.Lies = lies;
            this.Exams = new HashSet<Exam>();
        }

        public Challange() : this(System.Guid.NewGuid().ToString(), "Is this a question?", "Yes", new List<String>() { "No", "Maybe", "What is this?" } ) { }
    }
}