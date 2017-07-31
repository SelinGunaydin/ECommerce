using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.UI.Web.Models.VM
{
    public class SupplierVM : BaseEntityVM
    {
        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }
    }
}