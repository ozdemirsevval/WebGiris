using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class PersonelInsertVM
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Kullanıcı Kodu Zorunlu Alandır.")]
        [MinLength(4,ErrorMessage ="En Az Dört Hane Olamılıdır.")]
        [MaxLength(7,ErrorMessage ="En Fazla Yedi Karakter Olmalıdır.")]
        
        public string KullaniciAdi { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Kullanıcı Kodu Zorunlu Alandır.")]
        [MinLength(4, ErrorMessage = "En Az Dört Hane Olamılıdır.")]
        [MaxLength(7, ErrorMessage = "En Fazla Yedi Karakter Olmalıdır.")]
        public string Password { get; set; }

    }
}
