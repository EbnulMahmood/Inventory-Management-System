using InventoryManagementSystem.Application.Dtos;
using InventoryManagementSystem.Application.IServices;
using InventoryManagementSystem.Infrastructure.Extensions;
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
            var entities = await _service.ListEntitiesAsync();
            return View(entities);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryDto entity)
        {
            IDictionary<string, string> errors = _service.ValidateCategoryDto(entity);

            if (errors.Count > 0) ModelState.Merge(errors);
            if (!ModelState.IsValid) return View(entity);
            
            if (!await _service.CreateEntityAsync(entity)) return View(entity);
            TempData["success"] = "Category created successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}
