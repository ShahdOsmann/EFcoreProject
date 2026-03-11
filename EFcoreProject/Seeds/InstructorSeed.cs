using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject.Seeds
{
    public class InstructorSeed : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasData(
                new Instructor
                {
                    Id = 1,
                    FirstName = "Ahmed",
                    LastName = "Ali",
                    Phone = "0100000000",
                    DepartmentId = 1
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Sara",
                    LastName = "Hassan",
                    Phone = "0111111111",
                    DepartmentId = 2
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Mohamed",
                    LastName = "Khaled",
                    Phone = "0122222222",
                    DepartmentId = 1
                }
            );
        }
    }
}