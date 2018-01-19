using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using AdminData.Models;
using AdminData.DataAccess;
using AdminData.Utilities;

namespace AdminData.DataAccess
{
  public  class BaseRepository
  {
    protected IHostingEnvironment env;
    protected ContextExelOperations exelOperations;
    protected ContextInflow inflow;
    protected ContextWebsite website;
    protected string root;
    protected string sql;
    protected string filename;
    protected string script;

    public BaseRepository(IHostingEnvironment env, ContextExelOperations exelOperations, ContextInflow inflow, ContextWebsite website)
    {
      this.env = env;
      this.exelOperations = exelOperations;
      this.inflow = inflow;
      this.website = website;
      this.root = env.ContentRootPath;
    }
  }
}