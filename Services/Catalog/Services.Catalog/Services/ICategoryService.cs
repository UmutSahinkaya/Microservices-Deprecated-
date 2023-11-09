using Services.Catalog.Models;
using Services.Catalog.Models.Dtos;
using Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
