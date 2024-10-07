using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NorthwindEntities.SqlServerEntities;

namespace WebMVC.Controllers
{
    public class WebApiController:ControllerBase
    {
        private readonly SqlNorthwinContext db;

        public WebApiController(SqlNorthwinContext db)
        {
            this.db = db;
        }
        public IActionResult GetShippers()
        {
            var result = db.Shippers.ToList();
            if (result != null)
            {

                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
