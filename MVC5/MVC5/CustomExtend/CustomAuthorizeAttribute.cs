using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.CustomExtend
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 权限认证是发生此事件，标记特性的action'就会吸纳ontuthraizetion再action
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {            
            Console.WriteLine(filterContext.HttpContext) ;//httpcontext 包含所有的信息，可以做需要的功能

            if (filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true))
            {
                return;
            }
            else if (filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true))
            {
                return;
            }
            else
            {
                var userAccount = filterContext.HttpContext.Session["CurrentUser"];
                if (userAccount == null || userAccount.ToString() != "Bruce")
                {
                    //短路器
                    ////filterContext.Result = new ViewResult()
                    ////{
                    ////    ViewName = "~/Views/Second/Login.cshtml"
                    ////};

                    //filterContext.Result = new RedirectResult("~/Views/Second/Login.cshtml");
                }
                else
                {
                    return;
                }
            }
            //base.OnAuthorization(filterContext);//表示使用默认的认证方法
        }
    }
}