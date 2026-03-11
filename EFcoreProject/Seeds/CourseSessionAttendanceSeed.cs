using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject.Seeds
{
    public class CourseSessionAttendanceSeed : IEntityTypeConfiguration<CourseSessionAttendance>
    {
        public void Configure(EntityTypeBuilder<CourseSessionAttendance> builder)
        {
            builder.HasData(
                new CourseSessionAttendance
                {
                    Id = 1,
                    StudentId = 1,
                    CourseSessionId = 1,
                    Grade = 90,
                    Notes = "Excellent"
                },
                new CourseSessionAttendance
                {
                    Id = 2,
                    StudentId = 2,
                    CourseSessionId = 1,
                    Grade = 85,
                    Notes = "Very Good"
                }
            );
        }
    }
}