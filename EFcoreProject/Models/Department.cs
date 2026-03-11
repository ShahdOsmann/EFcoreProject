using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public string? location { get; set; } = null!;

        public int? ManagerId { get; set; }
        public Instructor? Manager { get; set; }

        public virtual ICollection<Instructor>? Instructors { get; set; }= new HashSet<Instructor>();
        public virtual ICollection<Course>? Courses { get; set; } = new HashSet<Course>();

    }
}
