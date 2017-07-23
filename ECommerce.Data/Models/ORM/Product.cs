using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }

        public int SupplierID { get; set; }

    }
}
