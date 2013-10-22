using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrbanImpact.Data.People;

namespace UrbanImpact.Data.Systems
{
    public class Options
    {
        public int OptionsId { get; set; }
        public Student Student { get; set; }
        public string PrimaryBus { get; set; }
        public string Comment { get; set; }
    }
}
