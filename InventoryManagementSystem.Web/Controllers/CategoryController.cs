using InventoryManagementSystem.Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var entities = await _service.LoadEntitiesAsync();
            return View(entities);
        }
    }
}
