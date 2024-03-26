using Data.Models;
using DataServices.Interfaces;
namespace DataServices.Services;

public class PatientRiskLevelService : PatientRelatedService<Data.Models.PatientRiskLevel>, IPatientRelatedService<PatientRiskLevel>
{
    public PatientRiskLevelService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-risk-levels") { }
}