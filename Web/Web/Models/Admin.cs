﻿using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? ActionHistory { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<News> News { get; set; } = new List<News>();
}
