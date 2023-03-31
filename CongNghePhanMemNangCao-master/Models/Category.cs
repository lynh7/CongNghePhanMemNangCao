using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class Category
    {
  

        public int CategoryID { get; set; }
        [Display(Name = "Tên Danh Mục")]
        public string tenCategory { get; set; }
        //nav
        public ICollection<TinRaoVat> TinRaoVats { get; set; }
        //public List<Category> List_Category { get; set; }
        
    }
}
