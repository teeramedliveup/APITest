using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMP.Common;

namespace WMP.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IConfigurationCommon configurationCommon)
       : base(configurationCommon) { }

        public ActionResult Index(string errorMsg)
        {
            ViewBag.ErrorMsg = errorMsg;
            return View();
        }

        #region [_Layout Contents]
        [ChildActionOnly]
        public ActionResult _SideNavbar()
        {
            // Load menu or data from DB here.
            // .......................

            return PartialView("~/Views/Shared/_SideNavbar.cshtml");
        }

        [ChildActionOnly]
        public ActionResult _TopNavbar()
        {
            // Load menu or data from DB here.
            // .......................

            return PartialView("~/Views/Shared/_TopNavbar.cshtml");
        }


        [ChildActionOnly]
        public ActionResult _LayoutFooter()
        {
            // Load menu or data from DB here.
            // .......................

            return PartialView("~/Views/Shared/_LayoutFooter.cshtml");
        }
        #endregion [_Layout Contents]
    }
}