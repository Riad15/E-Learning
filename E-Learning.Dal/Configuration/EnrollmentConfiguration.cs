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
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.EnrollmentDate)
                   .IsRequired();

            builder.HasOne(e => e.Student)
                   .WithMany(s => s.Enrollments)
                   .HasForeignKey(e => e.StudentId)
                   .IsRequired();

            builder.HasOne(e => e.Course)
                   .WithMany(c => c.Enrollments)
                   .HasForeignKey(e => e.CourseId)
                   .IsRequired();

            builder.HasIndex(e => new { e.StudentId, e.CourseId })
                   .IsUnique();
        }

    }
}
