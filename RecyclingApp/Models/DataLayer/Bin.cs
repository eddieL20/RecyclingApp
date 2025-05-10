using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RecyclingApp.Models.DataLayer;

public partial class Bin
{
    [Key]
    [Column("bin_id")]
    public int BinId { get; set; }

    [Column("tare_weight", TypeName = "decimal(6, 2)")]
    public decimal? TareWeight { get; set; }

    [Column("gross_weight", TypeName = "decimal(6, 2)")]
    public decimal? GrossWeight { get; set; }

    [Column("trailer_id")]
    public int? TrailerId { get; set; }

    [Column("material_id")]
    public int? MaterialId { get; set; }

    [Column("net_weight", TypeName = "decimal(7, 2)")]
    public decimal? NetWeight { get; set; }

    [ForeignKey("MaterialId")]
    [InverseProperty("Bins")]
    public virtual Material? Material { get; set; }

    [ForeignKey("TrailerId")]
    [InverseProperty("Bins")]
    public virtual Trailer? Trailer { get; set; }
}
