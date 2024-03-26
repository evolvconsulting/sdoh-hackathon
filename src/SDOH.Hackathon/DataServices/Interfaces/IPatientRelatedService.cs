using Data.Interfaces;
using Data.Models;

namespace DataServices.Interfaces;

public interface IPatientRelatedService<T> : IIdentifiedService<T>
        where T : class, IIdentified, IPatientRelated
{
    public Task<IEnumerable<T>> GetByPatient(string patientId);

}
