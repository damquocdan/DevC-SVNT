using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF8.Models​;

public partial class SinhVienHocBongTphcm
{
    public string Họ { get; set; } = null!;

    public string Tên { get; set; } = null!;

    public string MãKhoa { get; set; } = null!;

    public string NơiSinh { get; set; } = null!;

    public double? HọcBổng { get; set; }
}
