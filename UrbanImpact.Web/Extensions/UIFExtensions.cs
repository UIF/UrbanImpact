using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class UIFExtensions
    {
        static string UIFValidationSummary(this HtmlHelper helper, string validationMessage = "")
        {
            string retVal = "";
            if (helper.ViewData.ModelState.IsValid)
                return "";
            retVal += "<div class='alert alert-dismissable alert-danger'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>&times;</button>";
            if (!String.IsNullOrEmpty(validationMessage))
                retVal += helper.Encode(validationMessage);
            foreach (var key in helper.ViewData.ModelState.Keys)
            {
                foreach (var err in helper.ViewData.ModelState[key].Errors)
                    retVal += "<p>" + helper.Encode(err.ErrorMessage) + "</p>";
            }
            retVal += "</div>";
            return retVal.ToString();
        }
    }
}