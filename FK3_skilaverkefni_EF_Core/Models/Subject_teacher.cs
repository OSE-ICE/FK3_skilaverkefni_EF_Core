using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FK3_skilaverkefni_EF_Core.Models
{
    public class Subject_teacher
    {
        [Key, Column(Order = 0)]
        public int SubjectId { get; set; }

        [Key, Column(Order = 1)]
        public int TeacherId { get; set; }

        // Navigation properties
        public required Subjects Subject { get; set; }
        public required Teachers Teacher { get; set; }
    }
}
