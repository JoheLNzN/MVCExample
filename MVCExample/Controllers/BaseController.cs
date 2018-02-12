using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class BaseController : Controller
    {
        public DB_ICMEntities bd;

        public BaseController()
        {
            bd = new DB_ICMEntities();
        }
    }
}