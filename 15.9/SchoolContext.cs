using Microsoft.EntityFrameworkCore;
namespace OnlineCourses.CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        // Конструктор для DI (если будете использовать)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Опционально: конфигурации по умолчанию, ограничения, индексы и т.д.
            base.OnModelCreating(modelBuilder);

            // Пример: при удалении курса оставить преподавателя без привязки
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Course)
                .WithMany(c => c.Instructors)
                .HasForeignKey(i => i.CourseID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CourseID);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Student)
                .WithMany(s => s.Reviews)
                .HasForeignKey(r => r.StudentID);
        }
    }
}