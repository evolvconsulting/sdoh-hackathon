using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class ClaimTransaction : IIdentified
{
    public string? Id { get; set; }

    public string? Claimid { get; set; }

    public long? Chargeid { get; set; }

    public string? Patientid { get; set; }

    public string? Type { get; set; }

    public decimal? Amount { get; set; }

    public string? Method { get; set; }

    public string? Fromdate { get; set; }

    public string? Todate { get; set; }

    public string? Placeofservice { get; set; }

    public long? Procedurecode { get; set; }

    public string? Modifier1 { get; set; }

    public string? Modifier2 { get; set; }

    public long? Diagnosisref1 { get; set; }

    public long? Diagnosisref2 { get; set; }

    public long? Diagnosisref3 { get; set; }

    public long? Diagnosisref4 { get; set; }

    public long? Units { get; set; }

    public long? Departmentid { get; set; }

    public string? Notes { get; set; }

    public decimal? Unitamount { get; set; }

    public long? Transferoutid { get; set; }

    public string? Transfertype { get; set; }

    public decimal? Payments { get; set; }

    public long? Adjustments { get; set; }

    public decimal? Transfers { get; set; }

    public decimal? Outstanding { get; set; }

    public string? Appointmentid { get; set; }

    public string? Linenote { get; set; }

    public string? Patientinsuranceid { get; set; }

    public long? Feescheduleid { get; set; }

    public string? Providerid { get; set; }

    public string? Supervisingproviderid { get; set; }
}
