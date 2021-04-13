using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class DiagnosisDetailRepository : IDiagnosisDetail
    {
        private readonly AppDbContext context;

        public DiagnosisDetailRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<DiagnosisDetail> GetAllDiagnosisDetail
        {
            get
            {
                return context.DiagnosisDetails;
            }
        }

        public DiagnosisDetail GetDiagnosisDetailById(int diagnosisDetailId)
        {
            return context.DiagnosisDetails.FirstOrDefault(p => p.DiagnosisDetailId == diagnosisDetailId);
        }
    }
}
