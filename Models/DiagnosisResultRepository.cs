using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class DiagnosisResultRepository : IDiagnosisResult
    {
        private readonly AppDbContext context;

        public DiagnosisResultRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<DiagnosisResult> GetAllDiagnosisResults
        {
            get
            {
                return context.DiagnosisResults.Include(p => p.Patient); // include Patient data too
            }
        }

        public DiagnosisResult GetDiagnosisResultByDiagnosisDetailId(int diagnosisDetailId)
        {
            return context.DiagnosisResults.FirstOrDefault(p => p.DiagnosisResultId == diagnosisDetailId);
        }

        public DiagnosisResult GetDiagnosisResultlByPatientId(int patientId)
        {
            throw new NotImplementedException();
        }
    }
}
