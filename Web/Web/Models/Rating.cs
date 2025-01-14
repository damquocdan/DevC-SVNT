﻿using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Rating
{
    public int RatingId { get; set; }

    public int? CustomerId { get; set; }

    public int? HomestayId { get; set; }

    public int? TourId { get; set; }

    public int? RatingValue { get; set; }

    public string? ReviewComment { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Homestay? Homestay { get; set; }

    public virtual Tour? Tour { get; set; }
}
