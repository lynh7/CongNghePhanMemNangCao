using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Nhap.Models.Account
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public DateTime Brithday { get; set; }
    
    }
}
