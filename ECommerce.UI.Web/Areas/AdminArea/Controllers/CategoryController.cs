using ECommerce.Data.Models.ORM;
using ECommerce.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.UI.Web.Areas.AdminArea.Controllers
{
    public class CategoryController : BaseController
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CategoryVM model)
        {
            Category cat = new Category();
            cat.AddDate = DateTime.Now;
            cat.IsDeleted = false;
            cat.IsActive = true;
            cat.CategoryName = model.CategoryName;
            cat.Description = model.Description;
            
            rpcategory.Add(cat);
            rpcategory.Save();

            return View();
        }
    }
}