using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Reflection;
using System.Data.Linq.Mapping;

namespace UrbanImpact.Data
{
    public class UIFDataContext : DataContext
    {
        public UIFDataContext(string connStr) : base(connStr) { }

        [Function(Name = "GetOptionsDetails")]
        [ResultType(typeof(OptionsDataRow))]
        [ResultType(typeof(ActivityDataRow))]
        internal IMultipleResults GetOptionsDetails(int OptionsId)
        {
            IExecuteResult result = ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), OptionsId);
            return (IMultipleResults)result.ReturnValue;
        }
    }
}
