using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject.Seeds
{
    public class CourseSeed : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                new Course
                {
                    Id = 1,
                    Name = "Database Systems",
                    Duration = 40,
                    InstructorId = 1,
                    DepartmentId = 1
                },
                new Course
                {
                    Id = 2,
                    Name = "Operating Systems",
                    Duration = 45,
                    InstructorId = 3,
                    DepartmentId = 1
                }
            );
        }
    }
}