using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class OrderDetail : BaseEntity
    {
        public decimal? UnitPrice { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public int ProductID { get; set; }
        7
        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        public int OrderID { get; set; }

    }
}
