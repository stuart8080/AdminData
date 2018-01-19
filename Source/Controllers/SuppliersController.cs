using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminData.Controllers
{
    [Route("api/[controller]")]
    public class SuppliersController : Controller
    {
    [HttpGet("spreadsheet-detail")]
    public IActionResult GetSpreadsheetDetail([FromQuery] string supplier = "", string status = "")
    {
      return Ok();
    }
        
    }
}
