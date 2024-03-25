using Portal.Provider.Interfaces;

namespace Portal.Provider.Repositories;

public class PatientRepository : IRepository<Data.Models.Patient>
{
    public Data.Models.Patient Get(string id)
    {
        return new Data.Models.Patient();
    }

    public List<Data.Models.Patient> GetAll()
    {
        return new List<Data.Models.Patient>();
    }
}
