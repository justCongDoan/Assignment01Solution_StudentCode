using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace eStoreAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : Controller
    {
        private ICategoryRepository repository = new CategoryRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategorys() => repository.GetCategorys();

        [HttpPost]
        public IActionResult PostCategory(Category category)
        {
            repository.SaveCategory(category);
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult DeleteCategory(int id)
        {
            var category = repository.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }

            repository.DeleteCategory(category);
            return NoContent();
        }

        [HttpPut("id")]
        public IActionResult UpdateCategory(int id)
        {
            var category = repository.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }

            repository.UpdateCategory(category);
            return NoContent();
        }
    }
}
