using _8_WebApi_Cors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _8_WebApi_Cors.Controllers
{
    public class CategoriesController : ApiController
    {
        [HttpGet]
        //[EnableCors(origins: "http://localhost:36262/",headers:"*",methods:"*")]
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult Categories()
        {
            Entities db = new Entities();
            var catList = db.Categories.Select(x => new
            {
                x.CategoryID,
                x.CategoryName,
                x.Description
            }).ToList();
            return Json(catList);
        }
    }
}
