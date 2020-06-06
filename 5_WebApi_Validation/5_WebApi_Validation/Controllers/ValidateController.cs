using _5_WebApi_Validation.Filters;
using _5_WebApi_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5_WebApi_Validation.Controllers
{
    public class ValidateController : ApiController
    {
        //{"Id":"0","Name":"Bilal","Price":"10.0","Weight":"1000"}

        [HttpPost]
        [ValidateModel]
        public IHttpActionResult PostProduct(Product model)
        {
            return Ok(model);
        }
    }
}
