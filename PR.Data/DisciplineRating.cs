using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Data
{
    public class DisciplineRating
    {
        public int Id { get; set; }
        public int? DisciplineId { get; set; }
        public TeacherDisclipline? TeacherDisclipline { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public double AverageDisciplineRate { get; set; }
        public double InterestingnessRate { get; set; }
        public double ActualizationRate { get; set; }
        public double BenefitRate { get; set; }
        public DateTime? Created { get; set; }

    }
}
