﻿using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PaymentMethod
{
    public int MethodId { get; set; }

    public string? MethodName { get; set; }

    public string? Description { get; set; }
}