using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK3_skilaverkefni_EF_Core.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public required List<Students> StudentId { get; set; }
        public required List<Subjects> Subject_id { get; set; }
        public DateTime Date { get; set; }
        public int Mark { get; set; }
    }
}
