﻿using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string? Description { get; set; }

    public double? Price { get; set; }

    public int? HomestayId { get; set; }

    public int? TourId { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Homestay? Homestay { get; set; }

    public virtual Tour? Tour { get; set; }
}
