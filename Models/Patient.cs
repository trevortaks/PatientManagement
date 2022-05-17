using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string DateOfBirth { get; set; }
        public string NationalIDNo { get; set; }
        public string BirthEntryNo { get; set; }
        public string PassportNo { get; set; }
    }

    public class Observation
    {
        public int ObservationId { get; set; }
        public decimal Weight { get; set; }
        public string BloodPressure { get; set; }
        public decimal Temperature { get; set; }
        public decimal Height { get; set; }
        public BloodGroupEnum BloodGroup { get; set; }
    }

    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public string Description { get; set; }
        public string Treatment { get; set; }
    }

    public enum BloodGroupEnum
    {
        A, B , AB, O
    }
}
