using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
