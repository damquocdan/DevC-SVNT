﻿using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF8.Models​;

public partial class MonHoc
{
    public string MaMh { get; set; } = null!;

    public string TenMh { get; set; } = null!;

    public byte? Sotiet { get; set; }

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();
}
