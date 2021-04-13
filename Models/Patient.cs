using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class Patient
    {
        public Patient()
        {

        }
        public Patient(int patientId, string name, int age, string gender, string job, string phone, string address)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Gender = gender;
            Job = job;
            Phone = phone;
            Address = address;
        }

        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
