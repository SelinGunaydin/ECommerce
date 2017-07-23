using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class ProductImage
    {
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public int ProductID { get; set; }
    }
}
