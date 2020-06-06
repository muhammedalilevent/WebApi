using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _9_WebApi_Authorize.Models
{
    public class LoginModel
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}