using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ClassStudentMap : IEntityTypeConfiguration<ClassStudentEntity>
    {
        public void Configure(EntityTypeBuilder<ClassStudentEntity> builder)
        {
            builder.ToTable("ClassStudent");

            // builder.HasKey(cs => cs.Id);
            builder.HasKey(cs => new { cs.Id, cs.IdClass, cs.IdStudent });

            // builder.HasIndex(cs => cs.IdClass)
            //     .IsUnique();

            builder.Property(cs => cs.IdClass)
                .IsRequired()
                .HasMaxLength(36);

            // builder.HasIndex(cs => cs.IdStudent)
                // .IsUnique();

            builder.Property(cs => cs.IdStudent)
                .IsRequired()
                .HasMaxLength(36);
        }
    }
}
