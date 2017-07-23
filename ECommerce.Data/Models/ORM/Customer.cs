using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class Customer
    {
        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string Email { get; set; }

        public string CustomerPhone { get; set; }
    }
}
