using MVC5.CustomExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class ThirdController : Controller
    {
        // GET: Third
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info()
        {
            int i = 0;
            int m = 100 / i;

            return View();
        }

        //[HandleError]//mvc Filter       
        [CustomHandleErrorAttribute]//自定义filter  
        public ActionResult Exception()
        {
            int i = 0;
            int m = 100 / i;

            return View();
        }
    }
}