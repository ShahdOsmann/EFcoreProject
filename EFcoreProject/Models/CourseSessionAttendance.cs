using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject
{
    public  class CourseSessionAttendance
    {
        [Key]
        public int Id { get; set; }

        public int? Grade { get; set; }

        public string? Notes { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int CourseSessionId { get; set; }
        public CourseSession? CourseSession { get; set; }
    }
}
