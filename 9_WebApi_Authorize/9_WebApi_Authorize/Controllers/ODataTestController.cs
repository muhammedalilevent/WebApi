using _9_WebApi_Authorize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace _9_WebApi_Authorize.Controllers
{
    public class ODataTestController : ApiController
    {
        //Odata => Open Data'nın kısaltımışı database deki verileri çekerken query sorgu olarak çağırır ve javascripte yazdığımız url göre ek method açmadan tek bir merkezi noktadan sorgulama,fitreleme,arama gibi işlemleri yapabiliriz.

        //Odata ile bunu sorgulanabilir bir method haline getirdik
        //IQuarable dönüş tipinde sorgu döndüren methodlar tanımlıyoruz
        [Queryable]
        public IQueryable<TestModel> GetTest()
        {
            List<TestModel> list = new List<TestModel>();
            list.Add(new TestModel
            {
                Name = "Test1",
                Description = "TestDescription1",
                IsActive = true,
                MinValue = 10,
                MaxValue = 100
            });
            list.Add(new TestModel
            {
                Name = "Test2",
                Description = "TestDescription2",
                IsActive = true,
                MinValue = 20,
                MaxValue = 90
            });
            list.Add(new TestModel
            {
                Name = "Test3",
                Description = "TestDescription3",
                IsActive = false,
                MinValue = 30,
                MaxValue = 80
            });
            list.Add(new TestModel
            {
                Name = "Test4",
                Description = "TestDescription4",
                IsActive = false,
                MinValue = 40,
                MaxValue = 70
            });
            list.Add(new TestModel
            {
                Name = "Test5",
                Description = "TestDescription5",
                IsActive = true,
                MinValue = 50,
                MaxValue = 60
            });
            return list.AsQueryable();
        }
    
    }
}
