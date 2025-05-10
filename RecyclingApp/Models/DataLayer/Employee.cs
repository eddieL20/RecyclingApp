using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RecyclingApp.Models.DataLayer;

public partial class Employee
{
    [Key]
    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [Column("employee_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeName { get; set; }
}
