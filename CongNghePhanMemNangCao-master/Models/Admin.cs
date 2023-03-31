using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class Admin
    {
        public int AdminID { get; set; }
        [Display(Name = "Tài khoản")]
        public string adminName { get; set; }
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string adminPassword { get; set; }
    }
}
