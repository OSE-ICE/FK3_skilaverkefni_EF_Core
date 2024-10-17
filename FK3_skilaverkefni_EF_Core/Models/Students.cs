using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK3_skilaverkefni_EF_Core.Models
{
    public class Students
    {
        [Key]
        public required int StudentId { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public required List<Groups> Group_Id { get; set; }
    }
}
