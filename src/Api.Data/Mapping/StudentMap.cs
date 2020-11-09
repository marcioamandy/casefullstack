using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.ToTable("Student");

            builder.HasKey(s => s.Id);

            builder.HasIndex(s => s.Email)
                .IsUnique();

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.Email)
                .HasMaxLength(100);

            builder.Property(s => s.DateBirth)
                .IsRequired();
            
            builder.Property(c => c.Status)
                .IsRequired();
        }
    }
}
