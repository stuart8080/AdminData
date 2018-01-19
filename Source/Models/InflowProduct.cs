using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdminData.Models
{
  [Table("BASE_Product")]
  public class InflowProduct : BaseProduct
  {
    [Key]
    [Column("ProdId", TypeName = "int")]
    public  override int id { get; set; }

    [Column("Name", TypeName = "nvarchar(200)")]
    public override string Sku { get; set; }

    [Column("IsActive", TypeName = "bit")]
    public override bool Status { get; set; }

    [Column("LastModDttm", TypeName = "datetime")]
    public override DateTime LastUpdated { get; set; }
  }
}