using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class LoaiTin
    {

        public int LoaiTinID { get; set; }
        [Display(Name = "Tên Loại Tin")]
        public string tenLoaiTin { get; set; }
        //nav
        public ICollection<TinRaoVat> TinRaoVats { get; set; }
        //public List<LoaiTin> List_LoaiTin { get; set; }
    }
}
