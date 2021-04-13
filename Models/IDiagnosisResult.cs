using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    interface IDiagnosisResult
    {
        // Get all result
        IEnumerable<DiagnosisResult> GetAllDiagnosisResults { get; }
        // Get result by diag detail Id
        DiagnosisResult GetDiagnosisResultByDiagnosisDetailId(int diagnosisDetailId);
    }
}
