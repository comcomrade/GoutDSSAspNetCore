using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoutDSSAspNetCore.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser> // base for Identity to work with EF Core, IdentityUser represents a user 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DiagnosisDetail> DiagnosisDetails { get; set; }
        public DbSet<DiagnosisResult> DiagnosisResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Patient 
            modelBuilder.Entity<Patient>().HasData(new Patient { PatientId = 1, Name = "Nguyễn Minh Hưng", Age = 38, Gender = "Nam", Job = "Luật sư", Phone = "034323453", Address = "Lê Thanh Nghị, Đống Đa, Hà Nội" });
            modelBuilder.Entity<Patient>().HasData(new Patient { PatientId = 2, Name = "Lưu Minh Nghĩa", Age = 23, Gender = "Nam", Job = "Lập trình viên", Phone = "043454321", Address = "Quốc Tuấn, An Dương, Hải Phòng" });
            modelBuilder.Entity<Patient>().HasData(new Patient { PatientId = 1, Name = "Bùi Như Nguyệt", Age = 29, Gender = "Nữ", Job = "Giám đốc kinh doanh", Phone = "0903495044", Address = "Nhà Bè, Thủ Đức, Thành phố Hồ Chí Minh" });
            
            // Seed DiagnosisDetail
            modelBuilder.Entity<DiagnosisDetail>().HasData(new DiagnosisDetail { PatientId = 1, })
        }
    }
}
