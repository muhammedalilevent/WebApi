using _9_WebApi_Authorize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _9_WebApi_Authorize.Controllers
{
    public class UserController : ApiController
    {
        private const int userID = 1;
        private const string email = "test@test.com";

        public IHttpActionResult GetUserInformation(string Email, int UserID)
        {
            if (Email == email && userID == UserID)
            {
                UserInfoModel _currentUser = new UserInfoModel();
                _currentUser.Email = email;
                _currentUser.Name = "Bilal";
                _currentUser.SurName = "YILMAZ";
                _currentUser.UserName = "REIS";
                return Json(_currentUser);
            }
            return Unauthorized();
        }
    }
}
