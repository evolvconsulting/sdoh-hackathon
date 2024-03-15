using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PatientInterventionProgram : IIdentified
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [ForeignKey("InterventionID")]
        public int InterventionID { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
