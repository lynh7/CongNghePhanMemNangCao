using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class TinhTrang
    {
        public int TinhTrangID { get; set; }
        [Display(Name = "Tên Danh Mục")]
        public string tenTinhTrang { get; set; }
        //nav
        public ICollection<TinRaoVat> TinRaoVats { get; set; }
        //public List<TinhTrang> List_TinhTrang { get; set; }
    }
}
