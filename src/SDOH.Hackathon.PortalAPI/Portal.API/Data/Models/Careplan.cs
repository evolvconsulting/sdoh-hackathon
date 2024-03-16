﻿using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class Careplan : IIdentified
{
    public string? Id { get; set; }

    public DateOnly? StartTime { get; set; }

    public DateOnly? Stop { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }

    public long? Reasoncode { get; set; }

    public string? Reasondescription { get; set; }
}
