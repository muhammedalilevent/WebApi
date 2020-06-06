using _3_WebApi_Custom_Route.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _3_WebApi_Custom_Route.Controllers
{
    public class CategoryController : ApiController
    {
        public List<Category> CatDB
        {
            get
            {
                return new List<Category> {
                    new Category {
                        Id = 1,
                        CategoryName = "Cat1"
                    },
                    new Category {
                        Id = 2,
                        CategoryName = "Cat2"
                    },
                    new Category {
                        Id = 3,
                        CategoryName = "Cat3"
                    }
                };
            }
        }

        [HttpGet]
        public IHttpActionResult FilterCategory(string categoryType)
        {
            if (categoryType == "all")
            {
                return Ok(CatDB);
            }
            return Ok(CatDB.Where(x => x.CategoryName.Contains(categoryType)).ToList());
        }

        [HttpGet]
        public IHttpActionResult FilterCategoryById(int id)
        {
            return Ok(CatDB.Where(x => x.Id == id).ToList());
        }
    }
}
