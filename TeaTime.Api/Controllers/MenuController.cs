using Microsoft.AspNetCore.Mvc;
using TeaTime.Model.Entity;

namespace TeaTime.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        [HttpGet("GetMenuItems")]
        public ActionResult<IEnumerable<tProducts>> GetMenuItems()
       {

            // 假設 MenuItem 是你的品項模型
            var menuItems = new List<tProducts>
        {
            new tProducts { Name = "珍珠奶茶1", Price = 50 },
            new tProducts { Name = "紅茶00000", Price = 40 }
            // 加入其他品項
        };
            return Ok(menuItems);
        }
    }
}
