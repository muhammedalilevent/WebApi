using _5_WebApi_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5_WebApi_Validation.Controllers
{
    public class ProductController : ApiController
    {
        public IHttpActionResult Postproduct(Product model)
        {
            if (ModelState.IsValid)
            {
                return Ok(model);
            }
            return BadRequest(ModelState);
        }
    }
}
