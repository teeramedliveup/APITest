using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMP.Common;

namespace WMP.Controllers
{
    public class InventoryController : BaseController
    {
        public InventoryController(IConfigurationCommon configurationCommon)
       : base(configurationCommon) { }

        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }
    }
}