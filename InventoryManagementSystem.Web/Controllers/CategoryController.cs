using InventoryManagementSystem.Application.IDaos;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryDao _category;

        public CategoryController(ICategoryDao category)
        {
            _category = category;
        }

        public async Task<IActionResult> Index()
        {
            var entities = await _category.LoadCategoriesAsync();
            return View(entities);
        }
    }
}
