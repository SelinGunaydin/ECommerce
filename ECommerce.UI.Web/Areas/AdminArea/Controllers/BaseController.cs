using ECommerce.Business.RepositoryManager;
using ECommerce.Data.Models.ORM;
using ECommerce.UI.Web.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.UI.Web.Areas.AdminArea.Controllers
{
    public class BaseController : Controller
    {
        public Repository<Product> rpproduct;
        public Repository<Category> rpcategory;
        public Repository<Customer> rpcustomer;
        public Repository<Order> rporder;
        public Repository<OrderDetail> rporderdetail;
        public Repository<ProductImage> rpproimage;
        public Repository<Supplier> rpsupplier;
        //public Repository<CategoryVM> rpcategoryvm;

        public BaseController()
        {
            rpproduct = new Repository<Product>();
            rpcategory = new Repository<Category>();
            rpcustomer = new Repository<Customer>();
            rporder = new Repository<Order>();
            rporderdetail = new Repository<OrderDetail>();
            rpproimage = new Repository<ProductImage>();
            rpsupplier = new Repository<Supplier>();
            //rpcategoryvm = new Repository<CategoryVM>() ;
        }
    }
}