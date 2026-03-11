using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasMany(s => s.CourseStudents)
                   .WithOne(cs => cs.Student)
                   .HasForeignKey(cs => cs.StudentId);

            builder.HasMany(s => s.CourseSessionAttendances)
                   .WithOne(csa => csa.Student)
                   .HasForeignKey(csa => csa.StudentId);
        }
    }
}
