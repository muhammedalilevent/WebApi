using _6_ModelBinding_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _6_ModelBinding_1.Controllers
{
    public class GeoLocationController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Get([FromUri]int id, [FromBody]GeoLocation model)
        {
            return Ok(model);
        }
    }
}
