using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Car.BLL;
using Shop.Car.UI.Controllers;

namespace Shop.Car.UI.Controllers
{
    public class AdminController : BaseController
    {
        UserInfoBLL UserInfoBLL = new UserInfoBLL();
        OrderInfoBLL OrderInfoBLL = new OrderInfoBLL();
        // GET: Admin
        public ActionResult Index()
        {
            ViewData.Model = UserInfoBLL.GetAllModelList(u => u.UIsAdmin == 1);
            return View();
        }


        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult ShowOrder(int id)
        {
            ViewData.Model = OrderInfoBLL.GetAllModelList(o=>o.UId==id);
            return View();
        }


        public ActionResult DoworkOrder(int id)
        {
            if(OrderInfoBLL.DoworkOrder(id))
            {
                return Content("ok");
            }
            return Content("");
        }
    }
}