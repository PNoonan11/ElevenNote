using ElevenNote.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<NoteEntity> Notes { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NoteEntity>()
                .HasOne(n => n.Owner)
                .WithMany(p => p.Notes)
                .HasForeignKey(n => n.OwnerId);

            modelBuilder.Entity<NoteEntity>()
            .HasOne(c => c.CategoryId)
            .WithMany(p => p.Note)
            .HasForeignKey(n => n.Category);




        }
    }
}