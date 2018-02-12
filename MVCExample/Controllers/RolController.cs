﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class RolController : BaseController
    {

        public ActionResult Index()
        {
            var roles = (from r in bd.ADM_ROL
                         select r).ToList();

            return View(roles);
        }
    }
}