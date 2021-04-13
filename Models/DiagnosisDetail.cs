using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class DiagnosisDetail
    {
        public DiagnosisDetail()
        {

        }
        public int DiagnosisDetailId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime DiagnosisDate { get; set; } = DateTime.Now;
        public int CoTinhTheUrate { get; set; }
        public float SoDotDauKhopNgoaiBien { get; set; }
        public int DacDiemViemKhop { get; set; }
        public int SoTcDotViemCap { get; set; }
        public int CoMotConCap { get; set; }
        public int CoHatTophy { get; set; }
        public double NongDoAcidUric { get; set; }
        public int CoChanDoanAnh { get; set; }
        public int CoAnhXquang { get; set; }
        // property for one-one relationship with DiagnosisResult table
        public virtual DiagnosisResult Result { get; set; }
        // reference navigation property as a reference to Patient table (1-many relationship)
        public Patient PatientId { get; set; }
    }
}
