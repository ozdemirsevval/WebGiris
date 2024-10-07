using EmptyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyWeb.Controllers
{
    public class PersonelController :Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            PersonelViewModel personel = new();
            return View(personel);
        }
        [HttpPost]
        public IActionResult Index(PersonelViewModel personelvm)
        {
            Personel p = new Personel()
            {
                UserName= personelvm.UserName,
                Password=personelvm.Password,
                Ad=personelvm.Ad,
                Soyad=personelvm.Soyad,
                Email=personelvm.Email,
                Phone=personelvm.Phone
            };
            
            return RedirectToAction("Home");
        }

        public IActionResult PersonelListesi()
        {
            return View();
        }
    }
}
