using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdminData.Models
{
  [Table("Product")]
  public class WebsiteProduct : BaseProduct
  {
    [Key]
    [Column("Id", TypeName = "int")]
    public override int id { get; set; }

    public override string Sku { get; set; }

    [Column("Published", TypeName = "bit")]
    public override bool Status { get; set; }

    public bool Deleted { get; set; }

    [Column("UpdatedOnUtc", TypeName = "datetime")]
    public override DateTime LastUpdated { get; set; }
  }
}