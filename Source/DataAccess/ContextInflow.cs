using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AdminData.Models;

namespace AdminData.DataAccess
{
  public class ContextInflow : DbContext
  {

    private IConfigurationRoot config;

    public ContextInflow(IConfigurationRoot config)
    {
      this.config = config;
    }
    public DbSet<InflowProduct> InflowProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlServer(config["ConnectionString:InflowConnection"]);
    }
  }
}