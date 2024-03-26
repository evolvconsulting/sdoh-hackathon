using Data.Interfaces;
using Data.Models;

namespace Portal.Patient.Interfaces;

public interface IPatientRelatedService<T> : IIdentifiedService<T>
        where T : class, IIdentified
{
    public Task<IEnumerable<T>> GetByPatient(string patientId);

}
