using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrbanImpact.Web.Models
{
    public class BreadCrumb
    {
        public int OrderId { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
    }
}