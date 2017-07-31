using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.UI.Web.Models.VM
{
    public class CustomerVM : BaseEntityVM
    {
        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string Email { get; set; }

        public string CustomerPhone { get; set; }
    }
}