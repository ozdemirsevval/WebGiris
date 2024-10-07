using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using WebRazorPages.Models;

namespace WebRazorPages.Pages.Personel
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public PersonelViewModel Personel { get; set; } = new();
        public void OnGet()
        {
            
        }
        public IActionResult OnPost() 
        {
            WebRazorPages.Models.Personel p = new WebRazorPages.Models.Personel()
            {
                UserName = Personel.UserName,
                Password = Personel.Password,
                Ad = Personel.Ad,
                Soyad = Personel.Soyad,
                Email = Personel.Email,
                Phone = Personel.Phone
            };

           return  RedirectToPage("../Index");

        }
    }
}
