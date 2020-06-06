using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9_WebApi_Authorize.Models
{
    public class UserInfoModel : LoginModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string About { get; set; }
        public DateTime BirthDate { get; set; }

    }
}