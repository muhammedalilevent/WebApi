using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _10_WebApi_TokenBaseAuth.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Authorize] //Authorize attribute token olmayanların erişimini engeller
        //[Authorize(Roles = "user")] // kullanıcırolüne sahip olanlar sadece erişebilsin
        public IHttpActionResult Get()
        {
            List<string> data = new List<string>();
            data.Add("Test1");
            data.Add("Test2");
            data.Add("Test3");
            return Json(data);
        }
    }
}
