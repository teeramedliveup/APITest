using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMP.Common;

namespace WMP.Controllers
{
    public class BaseController : Controller
    {
        #region [Public Members]
        public readonly bool _IsDebug;
        public readonly string _indexPageUrl;
        #endregion [Public Members]

        #region [Private Members]
        private readonly IConfigurationCommon _configurationCommon;
        #endregion [Private Members]

        #region [Base controller constructor]
        public BaseController(IConfigurationCommon configurationCommon)
        {
            this._configurationCommon = configurationCommon;
            this._indexPageUrl = "~/Home/Index/?errorMsg=";

            this._IsDebug = this._configurationCommon.Setting<bool>("WMP.IsDebug");
        }
        #endregion [Base controller constructor]

        #region [Override controller]
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // This method excute before all action in controller excute.
            // Override code here
            // ..................

            base.OnActionExecuting(filterContext);
        }
        #endregion [Override controller]

        #region [Share Methods : Data & config]
        public void AllowAjaxOnly(bool isByPass = false)
        {
            if (!isByPass)
            {
                if (!Request.IsAjaxRequest())
                {
                    System.Web.HttpContext.Current.Response.Redirect(this._indexPageUrl, false);
                }
            }
        }

        public string GetUrlEncode(string input)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(input))
                result = System.Web.HttpUtility.UrlEncode(input);
            return result;
        }

        public string GetUrlDecode(string input)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(input))
                result = System.Web.HttpUtility.UrlDecode(input);
            return result;
        }

        public string GetCurrentRawUrl()
        {
            return System.Web.HttpContext.Current.Request.RawUrl;
        }

        #endregion [Share Methods : Data & config]
    }
}