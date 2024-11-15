using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF8.Models​;

public partial class Employee
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }
}
