namespace Portal.Provider.Services;

public class PatientDataService : BaseService<Data.Models.Patient>
{
    public PatientDataService(IHttpClientFactory clientFactory) : base(clientFactory, "patients")
    {
    }
}

//public class PatientDataService : IDataService<Patient>
//{
//    public IRepository<Patient> Repository { get; set; }

//    public PatientDataService(IRepository<Patient> repository)
//    {
//        Repository = repository;
//    }
//    public Patient GetById(string id)
//    {
//        return Repository.Get(id);
//    }

//    List<Patient> IDataService<Patient>.GetAll()
//    {
//        return Repository.GetAll();
//    }
//}
