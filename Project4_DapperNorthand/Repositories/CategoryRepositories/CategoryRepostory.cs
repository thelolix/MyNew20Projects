using Project4_DapperNorthand.dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_DapperNorthand.Repositories.CategoryRepositories
{
    public class CategoryRepostory : ICategoryRepository
    {

        public Task CreateCategoryAsync(CreateCategoryDto createcategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDto updatecategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}

