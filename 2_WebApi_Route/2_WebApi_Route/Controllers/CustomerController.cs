using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2_WebApi_Route.Controllers
{
    [RoutePrefix("api/Musteri")]
    public class CustomerController : ApiController
    {
        //api/Customer/MusteriGetir/5
        [HttpGet]
        public IHttpActionResult MusteriGetir(int id)
        {
            return Json(id.ToString());
        }

        //[NonAction] Servis olarak Metodumuz Çağrılmaz
        [Route("MusterileriListele")]
        public IHttpActionResult GetAllCustomers()
        {
            return Json("GetAllCustomers");
        }

        [AcceptVerbs("GET", "HEAD")]
        [ActionName("MusteriListele")]
        public IHttpActionResult List()
        {
            return Ok();
        }
    }
}
