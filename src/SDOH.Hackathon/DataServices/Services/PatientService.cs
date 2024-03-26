namespace DataServices.Services;

public class PatientService : BaseService<Data.Models.Patient>
{
    public PatientService(IHttpClientFactory clientFactory) : base(clientFactory, "patients") { }
}