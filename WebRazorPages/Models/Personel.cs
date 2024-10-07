namespace WebRazorPages.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly DogumTarihi { get; set; }
        public int Sehir { get; set; }
        public int Gelir { get; set; }
        public bool Cinsiyet { get; set; }
        public string Hobiler { get; set; }
    }
}
