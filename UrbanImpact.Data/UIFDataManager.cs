using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;

namespace UrbanImpact.Data
{
    public class UIFDataManager : IDisposable
    {
        private UIFDataContext _dataContext = null;

        protected UIFDataContext UIFDataContext
        {
            get {
                if (_dataContext == null)
                {
                    _dataContext = new UIFDataContext(ConfigurationManager.ConnectionStrings["live"].ConnectionString);
                }

                return _dataContext;            
            }
        }

        virtual public void Dispose()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
            }
        }
    }
}
