using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMP.Common;

namespace WMP.Controllers
{
    public class VendorController : BaseController
    {
        public VendorController(IConfigurationCommon configurationCommon)
       : base(configurationCommon) { }

        // GET: Vendor
        public ActionResult Index()
        {
            return View();
        }
    }
}