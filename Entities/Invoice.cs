﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BlazorApp.Shared;
public class Invoice
{
    public int? Id { get; set; }
    public User? User { get; set; }
    public List<Greeting>? Greetings { get; set; }
    public int? Year { get; set; }
    public int? Month { get; set; }
    public float? Cost { get; set; }
    public float? TotalCost { get; set; }
    public string? Currency { get; set; }

    public Invoice()
    {

    }
}
