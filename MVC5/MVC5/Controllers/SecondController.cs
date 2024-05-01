using MVC5.CustomExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class SecondController : Controller
    {
        //[CustomAuthorizeAttribute]//2.控制器注册
        public ActionResult Index()
        {
            return View();
        }

        //[CustomAuthorizeAttribute]
        public ActionResult Info()
        {
            return View();
        }
        
        [AllowAnonymous]//允许没登陆的用户使用login页面，此标记不是不走验证方法，而是在验证方法中处理它
        public ActionResult Login(string accout,string pwd)
        {
            if (accout == "bruce" && pwd == "123")
            {
                base.HttpContext.Session["CurrentUser"] = "Bruce";
                base.ViewBag.info = "Login Successed";
            }
            else
            {
                base.ViewBag.info = "Login Failed";
            }
            return View();
        }
    }
}