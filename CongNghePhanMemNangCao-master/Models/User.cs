using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Models
{
    public class User
    {
        [Display(Name = "Mã Người Dùng")]
        [Required(ErrorMessage = "Tên tài khoản không được trống")]
        public int UserID { get; set; }

        [Display(Name = "Tên Người Dùng")]
        [Required(ErrorMessage = "Tên tài khoản không được trống")]
        public string Username { get; set; }

        [Display(Name = "Mật Khẩu")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Mật khẩu không được trống")]
        public string Passoword { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Số điện thoại không được trống")]
        public string UserPhoneNumber { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email không được trống")]
        public string UserEmail { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string UserAddress { get; set; }
        [Display(Name = "Giới Tính")]
        public Nullable<bool> UserSex { get; set; }
        [Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> UserBirthday { get; set; }
        [Display(Name = "Họ Tên")]
        [Required(ErrorMessage = "Họ tên không được trống")]
        public string UserFullname { get; set; }

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Nhập Lại Mật Khẩu")]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        public string ErrorLogin { get; set; }

    }
}
