using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdminData.Models
{
  public class SpreadsheetDetail 
  {
    [Key]
    public int id { get; set; }
    public string SupplierCode { get; set; }
    public string Name { get; set; }
    public string Vintage { get; set; }
    public string Colour { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public string Grapes { get; set; }
    public int  CaseSize { get; set; }
    public string BottleSize { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string InflowSku { get; set; }
    public string InflowValue { get; set; }
    public string Status { get; set; }
  }
}
