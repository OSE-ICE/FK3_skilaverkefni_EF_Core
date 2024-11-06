﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK3_skilaverkefni_EF_Core.Models.DTO
{
    internal class TeacherDTO
    {
        [Key]
        public int Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
