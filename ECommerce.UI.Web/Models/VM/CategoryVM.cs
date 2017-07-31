using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.UI.Web.Models.VM
{
    public class CategoryVM : BaseEntityVM
    {
        [Required(ErrorMessage = "Lütfen kategori adı giriniz.")]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}