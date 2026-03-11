using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject.Seeds
{
    public class StudentSeed : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student { Id = 1, FirstName = "Omar", LastName = "Samy", Phone = "0101111111" },
                new Student { Id = 2, FirstName = "Mona", LastName = "Adel", Phone = "0102222222" },
                new Student { Id = 3, FirstName = "Youssef", LastName = "Hany", Phone = "0103333333" }
            );
        }
    }
}