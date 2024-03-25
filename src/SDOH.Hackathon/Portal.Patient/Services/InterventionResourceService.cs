namespace Portal.Patient.Services;

public class InterventionResourceService : BaseService<Data.Models.InterventionResource>
{
    public InterventionResourceService(IHttpClientFactory clientFactory) : base(clientFactory, "intervention-resources") { }
}