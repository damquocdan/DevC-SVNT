using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF8.Models​;

public partial class DeleteTable
{
    public string MaSv { get; set; } = null!;

    public string HoSv { get; set; } = null!;

    public string TenSv { get; set; } = null!;

    public bool Phai { get; set; }

    public DateTime NgaySinh { get; set; }

    public string NoiSinh { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public double? HocBong { get; set; }
}
