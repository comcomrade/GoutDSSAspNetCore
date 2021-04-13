using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class DiagnosisResult
    {
        public DiagnosisResult()
        {

        }
        // This annotations to refer to DiagnosisDetail as one-one rel
        [ForeignKey("DiagnosisDetail")]
        public int DiagnosisResultId { get; set; }
        public string Result { get; set; }

        public DiagnosisDetail DiagnosisDetailId { get; set; }
        // reference navigation property to Patient as one to many rel
        public Patient PatientId { get; set; }

        


    }
}
