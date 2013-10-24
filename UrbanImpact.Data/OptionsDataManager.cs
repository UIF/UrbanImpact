using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrbanImpact.Data.Systems;
using System.Data.Linq;
using UrbanImpact.Data.Common;

namespace UrbanImpact.Data
{
    internal class OptionsDataRow
    {
        public int OptionsId { get; set; }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PictureIdentification { get; set; }
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
    }
    internal class ActivityDataRow
    {
        public int ActivityId { get; set; }
        public string ActivityArea { get; set; }
        public int AreaId { get; set; }
        public string ActivityEntry { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime DateModified { get; set; }
    }

    public class OptionsDataManager : UIFDataManager
    {
        public List<Options> GetList()
        {
            string sql = "SELECT OptionsId, s.StudentId, s.FirstName, s.MiddleName, s.LastName, PrimaryBus, Comment " 
                           + "FROM Options o JOIN StudentInformation s on s.StudentId = o.StudentId";

            // default is false, so a bad login will return false
            return UIFDataContext.ExecuteQuery<OptionsDataRow>(sql).Select(x => new Options()
            {
                OptionsId = x.OptionsId,
                Student = new People.Student()
                {
                    StudentId = x.StudentId,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName
                },
                PrimaryBus = x.PrimaryBus,
                Comment = x.Comment
            }).ToList();
        }

        public Options Get(int OptionsId)
        {
            IMultipleResults results = UIFDataContext.GetOptionsDetails(OptionsId);
            var options = results.GetResult<OptionsDataRow>().Select(x => new Options()
            {
                OptionsId = x.OptionsId,
                Student = new People.Student()
                {
                    StudentId = x.StudentId,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName,
                    PictureUrl = x.PictureIdentification
                },
                PrimaryBus = x.PrimaryBus,
                Comment = x.Comment,
                DriversLicense = x.DriversLicense,
                BirthCertificate = x.BirthCertificate,
                PaIDCard = x.PaIDCard,
                HasGraduated = x.HasGraduated,
                BankAccount = x.BankAccount,
                SocialSecurityCard = x.SocialSecurityCard,
                AssessmentTesting = x.AssessmentTesting,
                PrimaryMentor = x.PrimaryMentor,
                HSTranscript = x.HSTranscript,
                HSGraduation = x.HSGraduation,
                GPA = x.GPA,
                GPADate = x.GPADate                
            }).Single();

            var activityList = results.GetResult<ActivityDataRow>().Select(x => new ActivityEntry()
            {
                ActivityId = x.ActivityId,
                ActivityLog = x.ActivityEntry,
                LastUpdatedBy = x.LastUpdatedBy,
                DateModified = x.DateModified
            }).ToList();

            options.ActivityEntries = activityList;

            return options;
        }
    }
}
