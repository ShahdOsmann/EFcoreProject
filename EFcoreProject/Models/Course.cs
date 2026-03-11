using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject
{
    public  class Course
    {
        [Key]
        public int Id { get; set; }
        public int? Duration { get; set; }
        public string? Name { get; set; } 
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public virtual ICollection<CourseSession>? CourseSessions { get; set; } = new HashSet<CourseSession>();

        public virtual ICollection<CourseStudent>? CourseStudents { get; set; } = new HashSet<CourseStudent>();
    }
}
