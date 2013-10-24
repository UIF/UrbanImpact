using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrbanImpact.Data.People;
using UrbanImpact.Data.Common;

namespace UrbanImpact.Data.Systems
{
    public class Options
    {
        public int OptionsId { get; set; }
        public Student Student { get; set; }
        public string PrimaryBus { get; set; }
        public string Comment { get; set; }
        public bool? DriversLicense { get; set; }
        public bool? BirthCertificate { get; set; }
        public bool? PaIDCard { get; set; }
        public bool? HasGraduated { get; set; }
        public bool? BankAccount { get; set; }
        public bool? SocialSecurityCard { get; set; }
        public DateTime? AssessmentTesting { get; set; }
        public string PrimaryMentor { get; set; }
        public DateTime? HSTranscript { get; set; }
        public DateTime? HSGraduation { get; set; }
        public string GPA { get; set; }
        public DateTime? GPADate { get; set; }
        public List<ActivityEntry> ActivityEntries { get; set; }
    }
}
