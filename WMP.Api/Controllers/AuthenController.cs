using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMP.ViewModels;
using Newtonsoft.Json;
using WMP.Application;

namespace WMP.Api.Controllers
{
    [Route("web/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        [HttpGet]
        [Route("sign_in")]
        public ActionResult sign_in()
        {
            VMResponse res = new VMResponse();
            res.is_success = true;
            res.message = string.Empty;
            res.result = "TOKEN";

            return new JsonResult(res);
        }

        [HttpPost]
        [Route("sign_in")]
        public JsonResult sign_in([FromBody] VMSignIn param)
        {
            AuthenApplication authApplication = new AuthenApplication();
            VMResponse res = authApplication.GetUserSignIn(param: param);
            return new JsonResult(res);
        }
    }
}