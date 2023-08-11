using Microsoft.EntityFrameworkCore;

namespace ThirdApp.API.Entities.Context;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{

	}

    public virtual DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(c =>
        {
            c.HasQueryFilter(x => x.IsDeleted == false);
            c.Property(x => x.IsDeleted).HasDefaultValue(false);
            c.Property(x => x.CreatedOn).HasDefaultValueSql("'getutcdate()'");
            c.Property(x => x.ModifiedOn).HasDefaultValueSql("'getutcdate()'");
        });
        base.OnModelCreating(modelBuilder);
    }
}
