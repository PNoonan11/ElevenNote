using Microsoft.AspNetCore.Mvc;
using ElevenNote.Services.Category;
using ElevenNote.Models.Category;

namespace ElevenNote.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<CategoryCreate>), 200)]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryCreate request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _categoryService.CreateCategoryAsync(request))
                return Ok("Category created successfully.");

            return BadRequest("Category could not be created");
        }

        [HttpGet]

        public async Task<IActionResult> GetByCategory([FromRoute] string category)
        {
            var categoryDetail = await _categoryService.GetNoteByCategoryAsync(category);
            if (categoryDetail is null)
            {
                return NotFound();
            }
            return Ok(categoryDetail);
        }








    }
}

