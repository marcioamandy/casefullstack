using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ClassMap : IEntityTypeConfiguration<ClassEntity>
    {
        public void Configure(EntityTypeBuilder<ClassEntity> builder)
        {
            builder.ToTable("Class");

            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Name)
                .IsUnique();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.DaysWeek)
                .HasMaxLength(100);

            builder.Property(c => c.DateStart)
                .IsRequired();

            builder.Property(c => c.DateEnd)
                .IsRequired();

            builder.Property(c => c.IdSchool)
                .IsRequired()
                .HasMaxLength(36);
            
            builder.Property(c => c.Status)
                .IsRequired();

        }
    }
}
