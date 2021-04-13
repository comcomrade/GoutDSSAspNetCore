using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public interface IDiagnosisDetail
    {
        // For seeing all newly and previous DiagnosisDetails in an table
        IEnumerable<DiagnosisDetail> GetAllDiagnosisDetail { get; }
        DiagnosisDetail GetDiagnosisDetailById(int diagnosisDetailId);
    }
}
