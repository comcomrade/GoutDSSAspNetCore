using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<DiagnoseStandards> Diagnoses { get; set; }
    }
}
