using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrbanImpact.Data.People;

namespace UrbanImpact.Data
{
    internal class StaffDataRow
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
    }
    public class AccountDataManager : UIFDataManager
    {
        public Staff Login(string username, string password)
        {
            string sql = "SELECT LastName, FirstName, Department from staffmembers where username = {0} and password = {1}";

            // default is false, so a bad login will return false
            return UIFDataContext.ExecuteQuery<Staff>(sql, username, password).Select(x => new Staff() 
                    { 
                        FirstName = x.FirstName, 
                        LastName = x.LastName, 
                        Department= x.Department
                    }).Single();
        }
    }
}
