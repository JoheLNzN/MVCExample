using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public JsonResult DeleteRol(int id)
        {
            bool deleted = false;

            try
            {
                var rol = bd.ADM_ROL.FirstOrDefault(x => x.ROL_ID == id);

                if (rol == null)
                    throw new Exception($"El rol con el id '{id}' no existe.");

                bd.Entry(rol).State = EntityState.Deleted;
                bd.SaveChanges();

                return Json(deleted, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}