using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
