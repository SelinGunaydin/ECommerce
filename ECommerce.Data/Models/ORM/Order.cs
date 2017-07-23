using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        public int CustomerID { get; set; }
    }
}
