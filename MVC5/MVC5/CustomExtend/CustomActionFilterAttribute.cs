using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO.Compression;

namespace MVC5.CustomExtend
{
    public class CustomActionFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Console.WriteLine(filterContext.HttpContext);

            filterContext.HttpContext.Response.Write($"this is {nameof(CustomActionFilterAttribute)} { nameof(OnActionExecuting)} { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")}");

            /*压缩--一般用不上，除非视频，音频等多媒体网站需要此功能，或者高频访的网站 ，高并发量。。。 ？？？*/
            /*
            string acceptEncoding = filterContext.HttpContext.Request.Headers["accept-encoding"];
            if (string.IsNullOrEmpty(acceptEncoding))
                return;//没有压缩格式，无法压缩
            else
            {
                if (acceptEncoding.ToLower().Contains("gzip"))
                {
                    var response = filterContext.HttpContext.Response;
                    response.AddHeader("content-encoding", "gzip");
                    response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
                }
            }
            */
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Console.WriteLine(filterContext.HttpContext);

            filterContext.HttpContext.Response.Write($"this is {nameof(CustomActionFilterAttribute)} { nameof(OnActionExecuting)} { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")}");


            ////base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //Console.WriteLine(filterContext.HttpContext);

            filterContext.HttpContext.Response.Write($"this is {nameof(CustomActionFilterAttribute)} { nameof(OnActionExecuting)} { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")}");


            ////base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //Console.WriteLine(filterContext.HttpContext);

            filterContext.HttpContext.Response.Write($"this is {nameof(CustomActionFilterAttribute)} { nameof(OnActionExecuting)} { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")}");


            ////base.OnActionExecuting(filterContext);
        }
    }
}