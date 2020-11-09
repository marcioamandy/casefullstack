using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<SchoolEntity> School { get; set; }
        public DbSet<ClassEntity> Class { get; set; }
        public DbSet<StudentEntity> Student { get; set; }
        public DbSet<ClassStudentEntity> ClassStudent { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<SchoolEntity>(new SchoolMap().Configure);
            modelBuilder.Entity<ClassEntity>(new ClassMap().Configure);
            modelBuilder.Entity<StudentEntity>(new StudentMap().Configure);
            modelBuilder.Entity<ClassStudentEntity>(new ClassStudentMap().Configure);
        }
    }
}
