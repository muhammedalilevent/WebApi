using _9_WebApi_Authorize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _9_WebApi_Authorize.Controllers
{
    public class AccountController : ApiController
    {
        private const string password = "123";
        private const string email = "test@test.com";

        public UserInfoModel PostLogin(LoginModel model)
        {
            if (model.Email == email && model.Password == password)
            {
                UserInfoModel _currentUser = new UserInfoModel();
                _currentUser.Email = email;
                _currentUser.Password = password;
               // _currentUser.UserID = 1;
                return _currentUser;
            }
            return null;
        }
    }
}
