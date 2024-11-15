using AsSplitQueryDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace AsSplitQueryDemo
{
    public class AsSplitQueryContext : DbContext
    {
        public AsSplitQueryContext(DbContextOptions<AsSplitQueryContext> options)
        : base(options)
        {
        }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<WriterProfile> WriterProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Writer>()
                .HasOne(a => a.Profile)
                .WithOne(p => p.Writer)
                .HasForeignKey<WriterProfile>(p => p.WriterId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Writer)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.WriterId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookId);
        }
    }
}
