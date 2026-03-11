using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject.Seeds
{
    public class CourseStudentSeed : IEntityTypeConfiguration<CourseStudent>
    {
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            builder.HasData(
                new CourseStudent { CourseId = 1, StudentId = 1 },
                new CourseStudent { CourseId = 1, StudentId = 2 },
                new CourseStudent { CourseId = 2, StudentId = 3 }
            );
        }
    }
}