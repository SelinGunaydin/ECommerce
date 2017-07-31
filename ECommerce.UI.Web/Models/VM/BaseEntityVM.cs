using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.UI.Web.Models.VM
{
    public class BaseEntityVM
    {
        public int ID { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime? UpdateDate { get; set; }

    }
}