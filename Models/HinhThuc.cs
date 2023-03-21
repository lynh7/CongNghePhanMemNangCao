using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class HinhThuc
    {
        public int HinhThucID { get; set; }
        [Display(Name = "Tên Hình Thức")]
        public string tenHinhThuc { get; set; }
        //nav
        public ICollection<TinRaoVat> TinRaoVats { get; set; }
        //public List<HinhThuc> List_HinhThuc { get; set; }
    }
}
