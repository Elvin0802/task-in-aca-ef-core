using Microsoft.EntityFrameworkCore;
//-----------------------------------



public class AppDbContext : DbContext
{

public DbSet<User> Users { get; set; }
public DbSet<Post> Posts { get; set; }
public DbSet<Tag> Tags { get; set; }




	public AppDbContext()
	{
		Database.EnsureDeleted();
		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Integrated Security = SSPI; Database = NanoInsta;");
	}

}
