using Shop.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Car.UI.Controllers
{
    public class BaseController : Controller
    {

        public bool IsCheckLogin = true;

        public static UserInfo BaseUserInfo { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if(IsCheckLogin)
            {
                if(BaseUserInfo == null)
                {
                    filterContext.HttpContext.Response.Redirect("/Login/Index");
                }
            }
        }
    }
}