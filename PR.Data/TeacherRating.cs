using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Data
{
    public class TeacherRating
    {
        public int Id { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public double AverageTeacherRating { get; set; }
        public double InterestingnessRate { get; set; }
        public double CommunicationRate { get; set; }
        public double OrganizationRate { get; set; }
        public string Comment { get; set; }
        public DateTime? Created { get; set; }
    }
}
