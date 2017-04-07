using Microsoft.EntityFrameworkCore;

namespace Test.Model
{
    public class TestContext : DbContext
    {
        public DbSet<AssessmentType> AssessmentTypes { get; set; }

        public TestContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssessmentType>()
                .ToTable("AssessmentType");

            modelBuilder.Entity<AssessmentType>()
                .Property(rp => rp.Cid)
                .HasMaxLength(1);

            modelBuilder.Entity<AssessmentType>()
                .Property(rp => rp.Code)
                .HasMaxLength(2)
                .IsRequired();

            modelBuilder.Entity<AssessmentType>()
                .Property(rp => rp.Description)
                .HasMaxLength(134)
                .IsRequired();

            modelBuilder.Entity<AssessmentType>()
                .Property(u => u.StartDate)
                .HasColumnType("date");

            modelBuilder.Entity<AssessmentType>()
                .Property(u => u.EndDate)
                .HasColumnType("date");
        }
    }
}
