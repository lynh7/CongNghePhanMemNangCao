using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class TrangThai
    {

        public int TrangThaiID { get; set; }
        [Display(Name = "Tên Danh Mục")]
        public string tenTrangThai { get; set; }
        //nav
        public ICollection<TinRaoVat> TinRaoVats { get; set; }
        //public List<TrangThai> List_TrangThai { get; set; }
    }
}
