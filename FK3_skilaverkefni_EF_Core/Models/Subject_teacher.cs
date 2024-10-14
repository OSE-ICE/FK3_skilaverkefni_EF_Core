using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK3_skilaverkefni_EF_Core.Models
{
    public class Subject_teacher
    {
        public required List<Subjects> Subject_Id { get; set; }
        public required List<Teachers> Teacher_Id { get; set; }
    }
}
