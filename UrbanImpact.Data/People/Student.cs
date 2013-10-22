using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UrbanImpact.Data.People
{
    public class Student
    {
        private string _pictureUrl;
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PictureUrl
        {
            get
            {
                return string.Format("{0}{1}", ConfigurationManager.AppSettings["oldSiteBaseUrl"], _pictureUrl.Substring(_pictureUrl.IndexOf("~")+2));
            }
            set
            {
                _pictureUrl = value;
            }
        }
        public string FullName
        {
            get
            {
                return string.Format("{0}, {1}", LastName, FirstName);
            }
        }
    }
}
