using ECommerce.UI.Web.Areas.AdminArea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ECommerce.UI.Web.Areas.AdminArea.Controllers
{
    public class HomeController : Controller
    {

        [LoginControl]
        public ActionResult Index()
        {
            return View();
        }
    }
}