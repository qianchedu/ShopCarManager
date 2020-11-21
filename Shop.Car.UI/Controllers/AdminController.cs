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


        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUser()
        {
            return View();
        }

        /// <summary>
        /// 订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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