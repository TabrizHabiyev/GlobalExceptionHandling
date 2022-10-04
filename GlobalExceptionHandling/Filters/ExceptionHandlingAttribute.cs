using System.Net;
using GlobalEx = GlobalExceptionHandling.ExceptionModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GlobalExceptionHandling.Filters
{
    public class ExceptionHandlingAttribute:ExceptionFilterAttribute
    {
      
      public override void OnException(ExceptionContext context)
      {

            if (context.Exception is GlobalEx.NotFoundException) context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
            else if (context.Exception is GlobalEx.UnauthorizedException) context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            else if (context.Exception is GlobalEx.ForbiddenException) context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            else if (context.Exception is GlobalEx.BadRequestException) context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            else if (context.Exception is GlobalEx.ConflictException) context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Conflict;
            else if (context.Exception is GlobalEx.NotImplementedException) context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotImplemented;
            else context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
    
            context.Result = new JsonResult(new { error = context.Exception.Message });
            context.ExceptionHandled = true;

      }
    }
}