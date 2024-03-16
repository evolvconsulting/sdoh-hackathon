using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class Claim : IIdentified
{
    public string? Id { get; set; }

    public string? Patientid { get; set; }

    public string? Providerid { get; set; }

    public string? Primarypatientinsuranceid { get; set; }

    public string? Secondarypatientinsuranceid { get; set; }

    public long? Departmentid { get; set; }

    public long? Patientdepartmentid { get; set; }

    public long? Diagnosis1 { get; set; }

    public long? Diagnosis2 { get; set; }

    public long? Diagnosis3 { get; set; }

    public long? Diagnosis4 { get; set; }

    public long? Diagnosis5 { get; set; }

    public long? Diagnosis6 { get; set; }

    public long? Diagnosis7 { get; set; }

    public long? Diagnosis8 { get; set; }

    public string? Referringproviderid { get; set; }

    public string? Appointmentid { get; set; }

    public string? Currentillnessdate { get; set; }

    public string? Servicedate { get; set; }

    public string? Supervisingproviderid { get; set; }

    public string? Status1 { get; set; }

    public string? Status2 { get; set; }

    public string? Statusp { get; set; }

    public decimal? Outstanding1 { get; set; }

    public decimal? Outstanding2 { get; set; }

    public long? Outstandingp { get; set; }

    public string? Lastbilleddate1 { get; set; }

    public string? Lastbilleddate2 { get; set; }

    public string? Lastbilleddatep { get; set; }

    public long? Healthcareclaimtypeid1 { get; set; }

    public long? Healthcareclaimtypeid2 { get; set; }
}
