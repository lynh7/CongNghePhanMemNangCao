using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class City
    { 
        public int CityID { get; set; }
        [Display(Name = "Tỉnh, Thành Phố")]
        public string tenThanhPho { get; set; }
        public string loaiThanhPho { get; set; }
        public string SLUG { get; set; }

        public  ICollection<TinRaoVat> TinRaoVats { get; set; }
        //public List<City> List_TinhThanhPho { get; set; }
    }
}
