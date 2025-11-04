using E_Learning.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Dal.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Code).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Credits).IsRequired();

            builder.HasMany(c => c.Enrollments)
                   .WithOne(e => e.Course)
                   .HasForeignKey(e => e.CourseId)
                   .IsRequired();
        }
        
    }
}
