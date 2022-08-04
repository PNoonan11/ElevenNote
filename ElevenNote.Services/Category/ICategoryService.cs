using ElevenNote.Data.Entities;
using ElevenNote.Models.Category;

namespace ElevenNote.Services.Category
{
    public interface ICategoryService
    {
        Task<bool> CreateCategoryAsync(CategoryCreate request);
        Task<CategoryEntity> GetNoteByCategoryAsync(string category);
    }
}