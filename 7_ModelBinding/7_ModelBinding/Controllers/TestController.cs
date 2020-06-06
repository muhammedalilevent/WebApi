using _7_ModelBinding.Attributes;
using _7_ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _7_ModelBinding.Controllers
{
    public class TestController : ApiController
    {
        //http://localhost:38939/api/test?Name=bisküvi&price=10
        [HttpGet,NotImplementedExecptionFilter]
        public IHttpActionResult Get([FromUri] Product model)
        {
            if (model.Name == null)
            {
                throw new NotImplementedException();
            }
            return Ok(model);
        }

        [NotImplementedExecptionFilter]
        public IHttpActionResult Post(Product model)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            return BadRequest();
        }

        public IHttpActionResult GetAuthorize(string role)
        {
            if (role != "Admin")
            {
                return Unauthorized();
            }
            return Ok();
        }

    }
}
