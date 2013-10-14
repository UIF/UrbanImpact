using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UrbanImpact.Data
{
    public class AccountDataManager : UIFDataManager
    {
        public bool Login(string username, string password)
        {
            string sql = "SELECT CAST(1 as bit) from staffmembers where username = {0} and password = {1}";

            // default is false, so a bad login will return false
            return UIFDataContext.ExecuteQuery<bool>(sql, username, password).SingleOrDefault();
        }
    }
}
