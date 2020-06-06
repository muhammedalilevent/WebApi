using _4_WebApi_XML_JSON_Serialize.Models;
using _4_WebApi_XML_JSON_Serialize.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace _4_WebApi_XML_JSON_Serialize.Controllers
{
    public class CustomController : ApiController
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

        //[{"urun_adi":"Test1","stok_miktari":50,"fiyat":10.0},{"urun_adi":"Test2","stok_miktari":100,"fiyat":15.0},{"urun_adi":"Test3","stok_miktari":150,"fiyat":20.0}]
        [HttpGet]
        public IHttpActionResult Serialize()
        {
            SerializeManager<List<Product>> manager = new SerializeManager<List<Product>>();
            var result = manager.Serialize<Product>(new JsonMediaTypeFormatter(), ListDB());
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult Deserialize()
        {
            string model = "[{ 'ürün_adi':'Test1','stok_miktari':50,'fiyat':10.0},{ 'ürün_adi':'Test2','stok_miktari':100,'fiyat':15.0}, {'ürün_adi':'Test3','stok_miktari':150,'fiyat':20.0}]";
            SerializeManager<List<Product>> manager = new SerializeManager<List<Product>>();
            List<Product> result = manager.DeSerialize<Product>(new JsonMediaTypeFormatter(), model);
            return Ok(result);
        }

    }
}
