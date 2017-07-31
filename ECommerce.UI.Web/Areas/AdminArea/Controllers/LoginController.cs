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
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AdminUser adminuser)
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

        //[Authorize]
        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();

            FormsAuthentication.SignOut();

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now);

            //return View();
            //Session.Clear();

            //FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Login");
        }
    }
}