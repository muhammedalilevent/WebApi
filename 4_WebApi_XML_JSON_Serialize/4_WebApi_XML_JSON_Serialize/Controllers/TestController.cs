using _4_WebApi_XML_JSON_Serialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _4_WebApi_XML_JSON_Serialize.Controllers
{
    public class TestController : ApiController
    {
        public List<Product> ListDB()
        {
            List<Product> plist = new List<Product>();
            plist.Add(new Product
            {
                Id = 1,
                ProductName = "Test1",
                Stock = 50,
                Price = 10
            });
            plist.Add(new Product
            {
                Id = 2,
                ProductName = "Test2",
                Stock = 100,
                Price = 15
            });
            plist.Add(new Product
            {
                Id = 3,
                ProductName = "Test3",
                Stock = 150,
                Price = 20
            });
            return plist;
        }

        public IHttpActionResult GetJson()
        {
            return Json(ListDB());
        }
        public IHttpActionResult GetXML()
        {
            return Ok(ListDB());
        }

    }
}
