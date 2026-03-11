using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject.Configurations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(i => i.ManagedDepartment)
            .WithOne(d => d.Manager)
             .HasForeignKey<Department>(d => d.ManagerId)
             .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(i => i.CourseSessions)
                .WithOne(cs => cs.Instructor)
                .HasForeignKey(cs => cs.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);  
        }
    }
}
