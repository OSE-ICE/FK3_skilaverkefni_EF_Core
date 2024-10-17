using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK3_skilaverkefni_EF_Core.Models
{
    public class Subjects
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
    }
}
