using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC5
{
    /// <summary>
    /// 验证用户登录--不重复代码的方法
    /// 1，方法注册--在每个control/action中进行验证，方法可行，代码重复过高，不适合
    /// 2.控制器注册，在action上添加 [CustomAuthorizeAttribute]标记即可，比较重的方法需要提前写好
    /// 3.全局注册，即在filterConfig中添加验证方法：filters.Add(new CustomExtend.CustomAuthorizeAttribute());//3.全局注册
    /// 对于不需要使用登录验证的action，可以在control、action的方法上添加[AllowAnonymous]
    /// 意思是：允许没登陆的用户使用login页面而不跳转到指定页面，此标记不是不走验证方法，而是在验证方法中处理它
    /// 原生MVC代码是又出力此标记的能力的，因为我们重写了验证功能
    /// 
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        /// 保底的，全局异常，没被抓住的异常均会在此出现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError();
            string msg = error.Message;
            Server.ClearError();
            this.Response.Write(msg);

            //((HttpException)error).GetHttpCod();
        }
    }
}
