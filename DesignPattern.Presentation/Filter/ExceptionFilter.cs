using DesignPattern.Presentation.Models;
using Logger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Presentation.Filter
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        private ILog _ILog;

        public ExceptionFilter()
        {
            _ILog = Log.GetInstance;
        }

        public override void OnException(ExceptionContext context)
        {
            _ILog.LogException(context.Exception.ToString());

            var result = new ViewResult { ViewName = "Error" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(
                    modelMetadata, context.ModelState);
            result.ViewData.Add("HandleException",
              context.Exception);
            context.ExceptionHandled = true;
            context.Result = result;
        }
    }
}
