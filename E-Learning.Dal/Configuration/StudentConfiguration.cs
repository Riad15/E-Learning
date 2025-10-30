using E_Learning.Model;
using  Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Dal.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Email).IsRequired().HasMaxLength(100);
            builder.Property(s => s.PhoneNumber).HasMaxLength(15);
            builder.HasOne(s => s.Address)
                   .WithOne(sa => sa.Student)
                   .HasForeignKey<StudentAddress>(sa => sa.StudentId)
                   .IsRequired();
        }

    }
}
