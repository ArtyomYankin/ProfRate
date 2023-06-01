using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Data
{
    public class TeacherDisclipline
    {
        public int Id { get; set; }
        public Teacher? Teacher {get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        [ForeignKey("Discipline")]
        public int? DisciplineId { get; set; }
        public virtual List<DisciplineRating> DisciplineRatings { get; set; }

    }
}
