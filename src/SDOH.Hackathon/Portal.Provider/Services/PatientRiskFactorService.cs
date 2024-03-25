﻿namespace Portal.Provider.Services;

public class PatientRiskFactorService : BaseService<Data.Models.PatientRiskFactor>
{
    public PatientRiskFactorService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-risk-factors") { }
}