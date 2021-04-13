using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext context;

        public PatientRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Patient> GetAllPatient
        {
            get
            {
                return context.Patients;
            }
        }

        public Patient GetPatientById(int patientId)
        {
            return context.Patients.FirstOrDefault(p => p.PatientId == patientId);
        }
    }
}
