using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.CustomExtend
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {
        //异常发生时，会进入的方法
        public override void OnException(ExceptionContext filterContext)
        {
            //HttpContext:请求的上下文，关键信息
            Console.WriteLine(filterContext.HttpContext);

            if (!filterContext.ExceptionHandled)//是否被其他方法被处理了
            {
                //log filterContext.HttpContext --记录需要的信息，输入。。。。
                //filterContext.Result = new RedirectResult("");

                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/Error.cshtml",
                    ViewData = new ViewDataDictionary<string>(filterContext.Exception.Message)
                };




                filterContext.ExceptionHandled = true;//处理完成后标记为已处理
            }

            //base.OnException(filterContext);
        }
    }
}