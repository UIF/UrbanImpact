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
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BusOption { get; set; }
        public string Comments { get; set; }
    }
    public class OptionsDataManager : UIFDataManager
    {
        public List<Options> Get()
        {
            string sql = "SELECT OptionsId, s.StudentId, s.FirstName, s.MiddleName, s.LastName, BusOption, Comments " 
                           + "FROM OptionsProgramNEW o JOIN StudentInformation s on s.StudentId = o.StudentId";

            // default is false, so a bad login will return false
            return UIFDataContext.ExecuteQuery<OptionsDataRow>(sql).Select(x => new Options() { 
                Student = new People.Student() { 
                    StudentId = x.StudentId,
                    FirstName = x.FirstName, 
                    MiddleName = x.MiddleName, 
                    LastName = x.LastName },
                OptionsId=x.OptionsId,
                BusOption=x.BusOption,
                Comments=x.Comments
                }).ToList();
        }
    }
}
