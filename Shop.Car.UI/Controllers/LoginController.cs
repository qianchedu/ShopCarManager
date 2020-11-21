using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Car.BLL;
using Shop.Car.Model;

namespace Shop.Car.UI.Controllers
{
    public class LoginController : BaseController
    {

        public LoginController()
        {
            IsCheckLogin = false;
        }

        UserInfoBLL userInfoBLL = new UserInfoBLL();
        public ActionResult Index()
        {
           
            return View();
        }


        public string CheckLogin(UserInfo userInfo)
        {
            UserInfo user = userInfoBLL.CheckLogin(userInfo);

            if (user == null)
            {
                return "";
            }

            BaseUserInfo = user;
            return user.UIsAdmin.ToString();
        }
    }
}