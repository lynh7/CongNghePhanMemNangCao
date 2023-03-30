using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Nhap.Models.ViewModel
{
    public class dangkyuser
    {
        public string Id { get; set; }
        [DisplayName("Tên đăng nhập")]
        [RegularExpression(@"^[^<>.,?;:'()!~%\-@#/*""\s]+$", ErrorMessage = "Tên đăng nhập không được có ký tự đặc biệt.")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống.")]
        [StringLength(50, ErrorMessage = "Tên đăng nhập không quá 50 ký tự.")]
        public string UserName { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [MinLength(8, ErrorMessage = "Mật khẩu cần dài ít nhất 8 ký tự.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [Compare("Password",ErrorMessage =("Mật khẩu không trùng khớp!"))]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        public long Phone { get; set; }
        [DisplayName("Email")]
        //[Required(ErrorMessage = "Please provide the invitee's Email Address")]
        [EmailAddress(ErrorMessage = "Vui lòng cung cấp Email hợp lệ")]
        public string Email { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public DateTime Brithday { get; set; }
    }
}
