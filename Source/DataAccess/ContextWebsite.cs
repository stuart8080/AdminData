using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AdminData.Models;

namespace AdminData.DataAccess
{
  public class ContextWebsite : DbContext
  {

    private IConfigurationRoot config;

    public ContextWebsite(IConfigurationRoot config)
    {
      this.config = config;
    }
    public DbSet<WebsiteProduct> WebsiteProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlServer(config["ConnectionString:WebsiteConnection"]);
    }
  }
}