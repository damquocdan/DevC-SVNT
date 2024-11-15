﻿using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Image
{
    public int ImageId { get; set; }

    public int? HomestayId { get; set; }

    public int? TourId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? ImageDescription { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Homestay? Homestay { get; set; }

    public virtual Tour? Tour { get; set; }
}
