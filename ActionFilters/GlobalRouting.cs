using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Capstone.ActionFilters
{
    public class GlobalRouting : IActionFilter
    {
        private readonly ClaimsPrincipal _claimsPrincipal;
        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimsPrincipal = claimsPrincipal;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {

            var controller = context.RouteData.Values["controller"];
            if (controller.Equals("Home"))
                if (_claimsPrincipal.IsInRole("Lower East Side"))
                {

                    context.Result = new RedirectToActionResult("Index", "Neighbor", null);
                }
                else if (_claimsPrincipal.IsInRole("River West"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);
                }
                else if (_claimsPrincipal.IsInRole("Downtown"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);

                }
                else if (_claimsPrincipal.IsInRole("Brewer's Hill"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);

                }
                else if (_claimsPrincipal.IsInRole("Franklin Heights"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);

                }
                else if (_claimsPrincipal.IsInRole("Third Ward"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);

                }
                else if (_claimsPrincipal.IsInRole("Walker's Point"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);

                }
                else if (_claimsPrincipal.IsInRole("Story Hill"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);

                }
                else if (_claimsPrincipal.IsInRole("Washington Heights"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);

                }
                else if (_claimsPrincipal.IsInRole("Bay View"))
                {
                    context.Result = new RedirectToActionResult("Index", "Home", null);

                }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
