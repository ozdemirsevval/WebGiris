using Microsoft.AspNetCore.Mvc;
using NorthwindEntities.SqlServerEntities;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class PersonelController : Controller
    {
        private readonly SqlNorthwinContext dbContext;

        public PersonelController(SqlNorthwinContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            PersonelInsertVM personelInsertVM = new PersonelInsertVM();
            return  View(PersonelInsertVM);
        }
    }
}
