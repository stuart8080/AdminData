using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using AdminData.DataAccess;


namespace AdminData.Controllers
{
    [Route("api/[controller]")]
    public class SuppliersController : Controller
    {
      private ISuppliersRepository supplierRepo;
      private IHostingEnvironment env;
      private IConfigurationRoot config;

    public SuppliersController(IConfigurationRoot config, ISuppliersRepository supplierRepo, IHostingEnvironment env)
    {
      this.supplierRepo = supplierRepo;
      this.env = env;
      this.config = config;
    }
    [HttpGet("spreadsheet-detail")]
    public IActionResult GetSpreadsheetDetail([FromQuery] string supplier = "", string status = "")
    {
      try { return Ok( new { data = supplierRepo.GetSpreadsheetDetail(supplier, status) }); }
      catch (Exception e) 
      { 
        return BadRequest(e); 
      }
    }
        
    }
}
