using System;
using System.Collections.Generic;

namespace TranThanhTung_2310900115.Models;

public partial class TttEmployee
{
    public int TttEmpId { get; set; }

    public string? TttEmpName { get; set; }

    public string? TttEmpLevel { get; set; }

    public DateOnly? TttEmpStartDate { get; set; }

    public bool? TttEmpStatus { get; set; }
}
