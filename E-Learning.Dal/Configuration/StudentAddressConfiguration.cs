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
    public class StudentAddressConfiguration : IEntityTypeConfiguration<StudentAddress>
    {
        public void Configure(EntityTypeBuilder<StudentAddress> builder)
        {
            builder.HasKey(sa => sa.Id);
            builder.Property(sa => sa.City).IsRequired().HasMaxLength(50);
            builder.Property(sa => sa.State).IsRequired().HasMaxLength(50);
            builder.Property(sa => sa.PostalCode).IsRequired().HasMaxLength(20);
            builder.Property(sa => sa.Country).IsRequired().HasMaxLength(50);
            builder.HasOne(sa => sa.Student)
                   .WithOne(s => s.Address)
                   .HasForeignKey<StudentAddress>(sa => sa.StudentId);
        }
    }
}
