using MVC5.CustomExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    [CustomActionFilterAttribute]
    public class FourthController : Controller
    {
        // GET: Fourth
        public ActionResult Index()
        {
            //ActionFilterAttribute
            return View();
        }
    }
}