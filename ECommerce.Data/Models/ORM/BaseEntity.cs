using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class BaseEntity
    {
        public int ID { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddDate { get; set; }
        
        public DateTime? UpdateDate { get; set; }

    }
}
