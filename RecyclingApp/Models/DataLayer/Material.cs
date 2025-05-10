using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RecyclingApp.Models.DataLayer;

public partial class Material
{
    [Key]
    [Column("material_id")]
    public int MaterialId { get; set; }

    [Column("material_name")]
    [StringLength(25)]
    [Unicode(false)]
    public string? MaterialName { get; set; }

    [Column("description")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("comments")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Comments { get; set; }

    [InverseProperty("Material")]
    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();
}
