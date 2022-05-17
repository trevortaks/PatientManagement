using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class PatientManagementContext : DbContext
    {
        public PatientManagementContext(DbContextOptions<PatientManagementContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Observation> Observation { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
    }
}
