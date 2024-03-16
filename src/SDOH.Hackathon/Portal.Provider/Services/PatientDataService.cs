namespace Portal.Provider.Services;

using Portal.Provider.Interfaces;
using System.Collections.Generic;
using ViewModels;

public class PatientDataService : IDataService<Patient>
{
    public IRepository<Patient> Repository { get; set; }

    public PatientDataService(IRepository<Patient> repository)
    {
        Repository = repository;
    }
    public Patient GetById(string id)
    {
        return Repository.Get(id);
    }

    List<Patient> IDataService<Patient>.GetAll()
    {
        return Repository.GetAll();
    }
}
