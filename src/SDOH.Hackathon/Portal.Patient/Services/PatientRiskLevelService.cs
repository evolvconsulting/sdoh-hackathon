﻿namespace Portal.Patient.Services;

public class PatientRiskLevelService : BaseService<Data.Models.PatientRiskLevel>
{
    public PatientRiskLevelService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-risk-levels") { }
}