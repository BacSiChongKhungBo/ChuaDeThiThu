using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Keyless]
[Table("Sinhvien")]
public partial class Sinhvien
{
    [Column("ten")]
    [StringLength(50)]
    public string? Ten { get; set; }

    [Column("nganh")]
    [StringLength(50)]
    public string? Nganh { get; set; }

    [Column("gioitinh")]
    public bool? Gioitinh { get; set; }
}
