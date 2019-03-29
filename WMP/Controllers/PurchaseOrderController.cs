using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMP.Common;

namespace WMP.Controllers
{
    public class PurchaseOrderController : BaseController
    {
        public PurchaseOrderController(IConfigurationCommon configurationCommon)
       : base(configurationCommon) { }

        // GET: PurchaseOrder
        public ActionResult Index()
        {
            return View();
        }
    }
}