using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UrbanImpact.Data.Common
{
    public class ActivityEntry
    {
        public int ActivityId { get; set; }
        public string ActivityArea { get; set; }
        public int AreaId { get; set; }
        public string ActivityLog { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
