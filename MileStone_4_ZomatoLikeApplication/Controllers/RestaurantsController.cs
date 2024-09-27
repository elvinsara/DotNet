using Microsoft.AspNetCore.Mvc;

namespace MileStone_4_ZomatoLikeApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantsController : Controller
    {
        
        
            private static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "Pizza Place", Address = "123 Main St", Rating = 4.5 },
        new Restaurant { Name = "Pasta House", Address = "456 Elm St", Rating = 4.2 }
    };

            [HttpGet]
            public ActionResult<IEnumerable<Restaurant>> Get()
            {
                return Ok(restaurants);
            }
        
        
    }
}
