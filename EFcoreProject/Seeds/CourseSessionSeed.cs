using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject.Seeds
{
    public class CourseSessionSeed : IEntityTypeConfiguration<CourseSession>
    {
        public void Configure(EntityTypeBuilder<CourseSession> builder)
        {
            builder.HasData(
                new CourseSession
                {
                    Id = 1,
                    title = "Introduction to Databases",
                    Date = new DateTime(2025, 1, 10),
                    InstructorId = 1,
                    CourseId = 1
                },
                new CourseSession
                {
                    Id = 2,
                    title = "SQL Basics",
                    Date = new DateTime(2025, 1, 12),
                    InstructorId = 1,
                    CourseId = 1
                }
            );
        }
    }
}