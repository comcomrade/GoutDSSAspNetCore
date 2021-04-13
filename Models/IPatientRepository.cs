using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAllPatient { get; }
        Patient GetPatientById(int patientId);
    }
}
