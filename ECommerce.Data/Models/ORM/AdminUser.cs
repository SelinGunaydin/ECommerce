using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.ORM
{
    public class AdminUser: BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
