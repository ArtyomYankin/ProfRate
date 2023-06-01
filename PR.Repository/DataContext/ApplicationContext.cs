using Microsoft.EntityFrameworkCore;
using PR.Data;

namespace PR.Repository.DataContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherRating> TeacherRatings { get; set; }
        public DbSet<Discipline> Disciplines{ get; set; }
        public DbSet<TeacherDisclipline> TeacherDisciplines{ get; set; }
        public DbSet<DisciplineRating> DisciplineRatings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherRating>()
            .HasOne(_ => _.Teacher)
            .WithMany(a => a.TeacherRatings)
            .HasForeignKey(p => p.TeacherId);
        }
    }
}
