using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject
{
    public class CourseSession
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string? title { get; set; }

        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public virtual ICollection<CourseSessionAttendance>? CourseSessionAttendances { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
