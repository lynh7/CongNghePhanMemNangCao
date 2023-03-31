using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CNPMNC.Models
{
    public class TinRaoVat
    {   
        public int TinRaoVatID { get; set; }
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        [Display(Name = "Trạng Thái")]
        public int TrangThaiID { get; set; }
        [Display(Name = "Tình Trạng")]
        public int TinhTrangID { get; set; }
        [Display(Name = "Loại Tin")]
        public int LoaiTinID { get; set; }
        [Display(Name = "Hình Thức")]
        public int HinhThucID { get; set; }
        [Display(Name = "Thành Phố")]
        public Nullable<int> CityID { get; set; }
        /*
        [Display(Name = "Mã Người Dùng")]
        public int maNguoiDung { get; set; }
        */

        [Display(Name = "Tiêu Đề")]
        public string TieuDe { get; set; }
        [Display(Name = "Hình Ảnh")]
        public string HinhAnh { get; set; }
        [Display(Name = "Nội Dung")]
        public string NoiDung { get; set; }
        [Display(Name = "Ngày giờ đăng")]
        public Nullable<System.DateTime> NgayGioDang { get; set; }
        [DisplayFormat(DataFormatString = "{0:0,0 vnđ}")]
        [Display(Name = "Giá")]
        public Nullable<int> GiaTinDang { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Ngày Hết Hạn")]
        public Nullable<System.DateTime> NgayHetHan { get; set; }

        
        public  Category Category { get; set; }
        
        public   HinhThuc HinhThuc { get; set; }
    
        public  LoaiTin  LoaiTin { get; set; }

        public  City City { get; set; }
       
        public  TinhTrang  TinhTrang { get; set; }
     
        public  TrangThai TrangThai { get; set; }

        [NotMapped]
        public IFormFile UploadImage { get; set; }


    }
}
