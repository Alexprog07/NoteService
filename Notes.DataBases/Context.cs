using Microsoft.EntityFrameworkCore;

namespace Notes.DataBases;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Note>().HasKey(x => x.Id);
        modelBuilder.Entity<Note>().Property(x => x.Id).HasMaxLength(150);
        base.OnModelCreating(modelBuilder);
    }
}