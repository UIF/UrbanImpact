using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrbanImpact.Data.Systems;

namespace UrbanImpact.Data
{
    internal class OptionsDataRow
    {
        public int OptionsId { get; set; }
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentMiddleName { get; set; }
        public string StudentLastName { get; set; }
        public string BusOption { get; set; }
        public string Comments { get; set; }
    }
    public class OptionsDataManager : UIFDataManager
    {
        public List<Options> Get()
        {
            string sql = "SELECT OptionsId, StudentId, StudentFirstName, StudentMiddleName, StudentLastName, BusOption, Comments FROM OptionsProgramNEW";

            // default is false, so a bad login will return false
            return UIFDataContext.ExecuteQuery<OptionsDataRow>(sql).Select(x => new Options() { 
                Student = new People.Student() { 
                    StudentId = x.StudentId,
                    FirstName = x.StudentFirstName, 
                    MiddleName = x.StudentMiddleName, 
                    LastName = x.StudentLastName },
                OptionsId=x.OptionsId,
                BusOption=x.BusOption,
                Comments=x.Comments
                }).ToList();
        }
    }
}
