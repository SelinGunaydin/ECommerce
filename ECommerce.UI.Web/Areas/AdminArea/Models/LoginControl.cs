using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.UI.Web.Areas.AdminArea.Models
{
    public class LoginControl : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                if (!HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    HttpContext.Current.Response.Redirect("/Login/Index");
                }
            }
        }

    }
