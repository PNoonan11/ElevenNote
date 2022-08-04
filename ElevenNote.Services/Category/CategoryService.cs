using ElevenNote.Data;
using ElevenNote.Data.Entities;
using ElevenNote.Models.Category;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateCategoryAsync(CategoryCreate model)
        {
            var categoryEntity = new CategoryEntity
            {
                CategoryName = model.CategoryName
            };
            _dbContext.Category.Add(categoryEntity);
            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<CategoryEntity> GetNoteByCategoryAsync(string categoryName)
        {
            return await _dbContext.Category.FirstOrDefaultAsync(category => category.CategoryName.ToLower() == categoryName.ToLower());

        }
    }
}