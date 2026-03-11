using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            builder.HasMany(d=>d.Courses)
                .WithOne(c=>c.Department)
                .HasForeignKey(c=>c.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    
    }
}
