using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject.Configurations
{
    public class CourseSessionConfiguration: IEntityTypeConfiguration<CourseSession>
    { 
        public void Configure(EntityTypeBuilder<CourseSession> builder)
        {
            builder.HasMany(cs => cs.CourseSessionAttendances)
                   .WithOne(csa => csa.CourseSession)
                   .HasForeignKey(csa => csa.CourseSessionId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
