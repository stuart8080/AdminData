using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AdminData.Models;
using System.Collections.Generic;

namespace AdminData.DataAccess
{
  public class ContextExelOperations : DbContext
  {

    private IConfigurationRoot config;

    public ContextExelOperations(IConfigurationRoot config)
    {
      this.config = config;
      Database.SetCommandTimeout(150000);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlServer(config["ConnectionString:ExelOperationsConnection"]);
    }

    public DbSet<SpreadsheetDetail> SpreadsheetDetail { get; set; }
  }
}