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
    public IActionResult GetSpreadsheetDetail([FromQuery] string supplier, string status)
    {
      if (string.IsNullOrEmpty(supplier)) {
        return BadRequest("Supplier not specified.");
      }
      if (string.IsNullOrEmpty(status)) {
        return BadRequest("Status not specified.");
      }
      return Ok();
    }
        
    }
}
