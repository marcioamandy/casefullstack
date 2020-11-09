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

            builder.HasKey(cs => cs.IdClass);
            builder.HasKey(cs => cs.IdStudent);

            builder.Property(cs => cs.IdClass)
                .IsRequired()
                .HasMaxLength(36);

            builder.Property(cs => cs.IdStudent)
                .IsRequired()
                .HasMaxLength(36);

        }
    }
}
