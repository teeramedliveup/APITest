using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMP.Common;

namespace WMP.Controllers
{
    public class InboundController : BaseController
    {
        public InboundController(IConfigurationCommon configurationCommon)
       : base(configurationCommon) { }

        // GET: Inbound
        public ActionResult Index()
        {
            return View();
        }
    }
}