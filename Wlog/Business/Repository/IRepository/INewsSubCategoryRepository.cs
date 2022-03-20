using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface INewsSubCategoryRepository
    {
        public Task<NewsSubCategoryDTO> CreateNewsSubCategory(NewsSubCategoryDTO newsSubCategoryDTO);
        public Task<NewsSubCategoryDTO> UpdateNewsSubCategory(int categoryId, NewsSubCategoryDTO newsSubCategoryDTO);
        public Task<NewsSubCategoryDTO> GetNewsSubCategory(int categoryId);
        public Task<int> DeleteNewsSubCategory(int categoryId);
        public Task<IEnumerable<NewsSubCategoryDTO>> GetAllNewsSubCategory();
    }
}
