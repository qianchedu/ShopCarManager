﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Car.UI.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}