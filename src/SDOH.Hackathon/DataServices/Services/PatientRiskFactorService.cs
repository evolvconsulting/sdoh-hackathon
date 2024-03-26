using Data.Models;
using DataServices.Interfaces;
namespace DataServices.Services;

public class PatientRiskFactorService : PatientRelatedService<Data.Models.PatientRiskFactor>, IPatientRelatedService<PatientRiskFactor>
{
    public PatientRiskFactorService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-risk-factors") { }
}