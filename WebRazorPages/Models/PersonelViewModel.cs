using System.ComponentModel.DataAnnotations;

namespace WebRazorPages.Models
{
    public class PersonelViewModel
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="User name alani zorunludur")]
        [MinLength(5,ErrorMessage ="Kullanici Adi En az 5 karakter olmalidir.")]
        [MaxLength(40,ErrorMessage ="40 karakterden fazla olamaz")]
        public string UserName { get; set; }
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler uyumsuz")]
        public string RePassword { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        
        
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
