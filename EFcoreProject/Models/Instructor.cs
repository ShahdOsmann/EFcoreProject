using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public string? Phone { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department? Department { get; set; }

        public virtual Department? ManagedDepartment { get; set; }

        public virtual ICollection<CourseSession>? CourseSessions { get; set; } = new HashSet<CourseSession>();

        public virtual ICollection<Course>? Courses { get; set; } = new HashSet<Course>();

    }
}
