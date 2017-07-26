using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Data.Models.ORM;
using System.Web.Security;

namespace ECommerce.UI.Web.Areas.AdminArea.Controllers
{
    public class LoginController : Controller
    {
        ECommerceContext db = new ECommerceContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AdminUser adminuser)
        {
            if (ModelState.IsValid)
            {
                if (db.AdminUsers.Any(x => x.Email == adminuser.Email && x.Password == adminuser.Password))
                {
                    FormsAuthentication.SetAuthCookie(adminuser.Email, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}