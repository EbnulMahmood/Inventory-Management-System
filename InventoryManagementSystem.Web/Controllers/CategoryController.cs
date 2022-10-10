using InventoryManagementSystem.Application.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var entities = await _repository.LoadCategoriesAsync();
            return View(entities);
        }
    }
}
