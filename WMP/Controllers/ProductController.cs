using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMP.Common;

namespace WMP.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IConfigurationCommon configurationCommon)
       : base(configurationCommon) { }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}