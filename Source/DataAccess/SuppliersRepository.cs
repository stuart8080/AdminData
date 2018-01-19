using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using AdminData.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections;

namespace AdminData.DataAccess
{
  public class SuppliersRepository : BaseRepository, ISuppliersRepository
  {
    private IConfigurationRoot config;

    public SuppliersRepository(IConfigurationRoot config, IHostingEnvironment env, ContextExelOperations exelOperations, ContextInflow inflow, ContextWebsite website) : base(env, exelOperations, inflow, website)
    {
      this.config = config;
    }

    public IEnumerable<SpreadsheetDetail> GetSpreadsheetDetail(string supplier, string status)
    {
      try
      {
        //
        // var p1 = supplier.NoNull();
        // var p2 = status.NoNull();
        var p1 = supplier;
        var p2 = status;
        
        
         var stu = exelOperations.SpreadsheetDetail.FromSql("sup.GetSpreadsheetDetail @p0, @p1", p1,p2).ToList();
         return stu;
      }
      catch (Exception) 
      { 
        throw; 
      } 
    }

  }
}