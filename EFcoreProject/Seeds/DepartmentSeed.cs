using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject
{
    public class DepartmentSeed : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department
                {
                    DepartmentId = 1,
                    Name = "Computer Science",
                    location = "Building A" 
                },
                new Department
                {
                    DepartmentId = 2,
                    Name = "Information Systems",
                    location = "Building B" 
                }
            );
        }
    }
}