using Portal.Patient.Interfaces;

namespace Portal.Patient.Models
{
    public class Intervention : IIntervention
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
