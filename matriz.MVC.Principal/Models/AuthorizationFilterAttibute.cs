using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace matriz.MVC.Principal.Models;

public class AuthorizationFilterAttibute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var funcionarioId = context.HttpContext.Session.GetInt32("funcionarioId") ?? 0;
        
        //if (funcionarioId == 0)
        //{
        //    context.Result = new RedirectToRouteResult(
        //            new RouteValueDictionary(
        //                    new { controller = "Home", action = "Index" }
        //                )
        //        );

        //}
    }
}
