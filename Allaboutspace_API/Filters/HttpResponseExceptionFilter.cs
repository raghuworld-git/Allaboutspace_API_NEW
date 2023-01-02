using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Core;

namespace Allaboutspace_API.Filters
{
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order => int.MaxValue - 10;

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is CustomException httpResponseException)
            {
                context.Result = new ObjectResult(httpResponseException)
                {                   
                    StatusCode = httpResponseException.CustomStatusCode,
                    Value = httpResponseException.CustomMessage
                };

                context.ExceptionHandled = true;
            }
        }
      
    }
}
