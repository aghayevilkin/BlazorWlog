using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class NewsSubCategoryRepository : INewsSubCategoryRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public NewsSubCategoryRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<NewsSubCategoryDTO> CreateNewsSubCategory(NewsSubCategoryDTO newsSubCategoryDTO)
        {
            NewsSubCategory newsCategory = _mapper.Map<NewsSubCategoryDTO, NewsSubCategory>(newsSubCategoryDTO);
            var addedNewsCategory = await _db.NewsSubCategories.AddAsync(newsCategory);

            await _db.SaveChangesAsync();
            return _mapper.Map<NewsSubCategory, NewsSubCategoryDTO>(addedNewsCategory.Entity);
        }

        public async Task<int> DeleteNewsSubCategory(int categoryId)
        {
            var category = await _db.NewsSubCategories.FindAsync(categoryId);
            if (category != null)
            {
                _db.NewsSubCategories.Remove(category);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<NewsSubCategoryDTO>> GetAllNewsSubCategory()
        {
            try
            {
                IEnumerable<NewsSubCategoryDTO> newsSubCategoryDTO =
                    _mapper.Map<IEnumerable<NewsSubCategory>, IEnumerable<NewsSubCategoryDTO>>(_db.NewsSubCategories).OrderByDescending(x=>x.Id);

                return newsSubCategoryDTO;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<NewsSubCategoryDTO> GetNewsSubCategory(int? categoryId)
        {
            try
            {
                NewsSubCategoryDTO newsCategory = _mapper.Map<NewsSubCategory, NewsSubCategoryDTO>(
                    await _db.NewsSubCategories.FirstOrDefaultAsync(x => x.Id == categoryId));

                return newsCategory;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<NewsSubCategoryDTO> UpdateNewsSubCategory(int categoryId, NewsSubCategoryDTO newsSubCategoryDTO)
        {
            try
            {
                if (categoryId == newsSubCategoryDTO.Id)
                {
                    //valid
                    NewsSubCategory categoryDetails = await _db.NewsSubCategories.FindAsync(categoryId);
                    NewsSubCategory category = _mapper.Map<NewsSubCategoryDTO, NewsSubCategory>(newsSubCategoryDTO, categoryDetails);
                    var updateCategory = _db.NewsSubCategories.Update(category);

                    await _db.SaveChangesAsync();
                    return _mapper.Map<NewsSubCategory, NewsSubCategoryDTO>(updateCategory.Entity);
                }
                else
                {
                    //invalid
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
