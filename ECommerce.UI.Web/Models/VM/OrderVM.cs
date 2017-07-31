using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.UI.Web.Models.VM
{
    public class OrderVM : BaseEntityVM
    {
        public DateTime OrderDate { get; set; }

        public int CustomerID { get; set; }
    }
}