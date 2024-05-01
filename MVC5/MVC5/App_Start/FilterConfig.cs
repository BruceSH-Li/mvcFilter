using System.Web;
using System.Web.Mvc;

namespace MVC5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExtend.CustomAuthorizeAttribute());//3.全局注册
            filters.Add(new CustomExtend.CustomHandleErrorAttribute());//3.全局注册
            filters.Add(new CustomExtend.CustomActionFilterAttribute());//3.全局注册

            /*CustomActionFilterAttribute*/
            //权限--比如检查是否登录，但是一般在权限fliter的里面做，更合适
            //日志--OK
            //接口校验--可以检查参数
            //方法+安全检查--检查注入SQL
            //性能测试--可以
            
            
            //压缩--网站运营模式是 请求-响应-，传输数据流-就有压缩的需求，一提升网站的运行效率
            //在浏览器请求时，申明支持的压缩类型，浏览器自带的功能
            //浏览器响应时就会压缩内容，通过content-encoding压缩内容
            //浏览器会根据压缩格式自行解压--可以节约带宽，效率
            //actionFilter 判断压缩格式--header指定压缩--配置压缩Filter
            //带来新的服务器cpu压力，--不过很微小



            //缓存
            /*
             
             
             */
        }
    }
}
