using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF8.Models​;

public partial class DanhSachSinhVien
{
    public string MãSinhViên { get; set; } = null!;

    public string HọSinhViên { get; set; } = null!;

    public string TênSinhViên { get; set; } = null!;

    public bool GiớiTính { get; set; }

    public DateTime NgàySinh { get; set; }

    public string NơiSinh { get; set; } = null!;

    public string MãKhoa { get; set; } = null!;

    public double? HọcBổng { get; set; }

    public double? ĐiểmTrungBình { get; set; }
}
