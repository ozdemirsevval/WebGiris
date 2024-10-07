using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindEntities.SqlServerEntities;
using System.ComponentModel;

namespace WebRazorPages.Pages.Shipper
{
    public class IndexModel : PageModel
    {
        private readonly SqlNorthwinContext db;

        public IndexModel(SqlNorthwinContext db)
        {
            this.db = db;
        }
        [BindProperty]
        public List<NorthwindEntities.SqlServerEntities.Shipper> Shippers { get; set; } = new();
        public void OnGet()
        {
            Shippers = db.Shippers.ToList();
        }
    }
}
