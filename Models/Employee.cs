using System;
using System.Collections.Generic;

namespace TaskManagement.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Employeename { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Department { get; set; }

    public string? Designation { get; set; }
}
