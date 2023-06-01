﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Data
{
    public class Discipline
    {
        [Key]
        public int DisciplineId { get; set; }
        public string DisciplineName { get; set; } = string.Empty;
        public string DisciplineDescription { get; set; } = string.Empty;
    }
}
