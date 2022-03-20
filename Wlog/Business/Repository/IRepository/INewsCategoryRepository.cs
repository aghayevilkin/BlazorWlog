using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface INewsCategoryRepository
    {
        public Task<NewsCategoryDTO> CreateNewsCategory(NewsCategoryDTO newsCategoryDTO);
        public Task<NewsCategoryDTO> UpdateNewsCategory(int categoryId, NewsCategoryDTO newsCategoryDTO);
        public Task<NewsCategoryDTO> GetNewsCategory(int categoryId);
        public Task<int> DeleteNewsCategory(int categoryId);
        public Task<IEnumerable<NewsCategoryDTO>> GetAllNewsCategory();
    }
}
