using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.UI.Web.Models.VM
{
    public class ProductVM : BaseEntityVM
    {
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int CategoryID { get; set; }

        public int SupplierID { get; set; }

    }
}