using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirstEFCore.Models;

public partial class Student
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Gender { get; set; }

    [Required]
    public int? Age { get; set; }

    [Required]
    public int? Standard { get; set; }
}
