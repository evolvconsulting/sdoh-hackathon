using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class ImagingStudy : IIdentified
{
    public string? Id { get; set; }

    public string? Date { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public string? SeriesUid { get; set; }

    public long? BodysiteCode { get; set; }

    public string? BodysiteDescription { get; set; }

    public string? ModalityCode { get; set; }

    public string? ModalityDescription { get; set; }

    public string? InstanceUid { get; set; }

    public string? SopCode { get; set; }

    public string? SopDescription { get; set; }

    public long? ProcedureCode { get; set; }
}
