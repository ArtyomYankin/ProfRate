using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Data
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string JobTitle { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public ICollection<TeacherRating>? TeacherRatings { get; set; }
        public ICollection<TeacherDisclipline>? TeacherDisciplines { get; set; }

    }
}
