using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.UI.Web.Areas.AdminArea.Controllers
{
    public class CategoryController : Controller
    {
        // GET: AdminArea/Category
        public ActionResult Index()
        {
            return View();
        }
    }
}