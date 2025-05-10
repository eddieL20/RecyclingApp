using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RecyclingApp.Models.DataLayer;

public partial class Trailer
{
    [Key]
    [Column("trailer_id")]
    public int TrailerId { get; set; }

    [Column("total_weight", TypeName = "decimal(18, 0)")]
    public decimal? TotalWeight { get; set; }

    [Column("arrival_date", TypeName = "datetime")]
    public DateTime? ArrivalDate { get; set; }

    [Column("completion_date", TypeName = "datetime")]
    public DateTime? CompletionDate { get; set; }

    [Column("from_location")]
    [StringLength(25)]
    [Unicode(false)]
    public string? FromLocation { get; set; }

    [Column("dock_num")]
    public int? DockNum { get; set; }

    [InverseProperty("Trailer")]
    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();
}
