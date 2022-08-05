using System.Security.Claims;
using AutoMapper;
using ElevenNote.Data;
using ElevenNote.Data.Entities;
using ElevenNote.Models.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly int _categoryId;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _dbContext;
        public CategoryService(IHttpContextAccessor httpContextAccessor, IMapper mapper, ApplicationDbContext dbContext)
        {
            // var categoryClaims = httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            // var value = categoryClaims.FindFirst("Id")?.Value;
            // var validId = int.TryParse(value, out _categoryId);
            // if (!validId)
            //     throw new Exception("Attempted to build NoteService without User Id claim.");

            _dbContext = dbContext;
            _mapper = mapper;
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