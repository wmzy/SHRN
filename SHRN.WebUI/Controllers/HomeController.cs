using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace SHRN.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 0)
        {
            if (id != 0)
            {
                if (Request.IsAuthenticated && id == WebSecurity.CurrentUserId)
                {
                    ViewBag.Message = "我的主页";

                    return View("MyIndex");
                }
                else
                {
                    ViewBag.Message = WebSecurity.CurrentUserId.ToString() + "来到了" + id.ToString() + "的主页";

                    return View("OthersIndex");
                }
            }

            ViewBag.Message = "网站主页";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "树仁网 - 我们不仅仅发现人才。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "1256573276@qq.com OR 1203846281@qq.com";

            return View();
        }
    }
}
