using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdminData.Models
{
  public abstract class BaseProduct
  {
     public abstract int id { get; set; }
     public abstract string Sku { get; set; }
     public abstract bool Status { get; set; }
     public abstract DateTime LastUpdated { get; set; }
  }
}