using Project4_DapperNorthand.dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_DapperNorthand.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();

        Task CreateCategoryAsync(CreateCategoryDto createcategoryDto);

        Task UpdateCategoryAsync(UpdateCategoryDto updatecategoryDto);

        Task DeleteCategoryAsync(int id);

        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);
    }
}