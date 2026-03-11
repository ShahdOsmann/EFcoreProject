using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string?FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<CourseStudent>? CourseStudents { get; set; } = new HashSet<CourseStudent>();
        public virtual ICollection<CourseSessionAttendance>? CourseSessionAttendances { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
