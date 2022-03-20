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
    public class NewsCategoryRepository : INewsCategoryRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public NewsCategoryRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<NewsCategoryDTO> CreateNewsCategory(NewsCategoryDTO newsCategoryDTO)
        {
            NewsCategory newsCategory = _mapper.Map<NewsCategoryDTO, NewsCategory>(newsCategoryDTO);
            var addedNewsCategory = await _db.NewsCategories.AddAsync(newsCategory);

            await _db.SaveChangesAsync();
            return _mapper.Map<NewsCategory, NewsCategoryDTO>(addedNewsCategory.Entity);
        }

        public async Task<int> DeleteNewsCategory(int categoryId)
        {
            var category = await _db.NewsCategories.FindAsync(categoryId);
            if (category != null)
            {
                _db.NewsCategories.Remove(category);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<NewsCategoryDTO>> GetAllNewsCategory()
        {
            try
            {
                IEnumerable<NewsCategoryDTO> newsCategoryDTO =
                    _mapper.Map<IEnumerable<NewsCategory>, IEnumerable<NewsCategoryDTO>>(_db.NewsCategories).OrderByDescending(x => x.Id);

                return newsCategoryDTO;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<NewsCategoryDTO> GetNewsCategory(int categoryId)
        {
            try
            {
                NewsCategoryDTO newsCategory = _mapper.Map<NewsCategory, NewsCategoryDTO>(
                    await _db.NewsCategories.FirstOrDefaultAsync(x => x.Id == categoryId));

                return newsCategory;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<NewsCategoryDTO> UpdateNewsCategory(int categoryId, NewsCategoryDTO newsCategoryDTO)
        {
            try
            {
                if (categoryId == newsCategoryDTO.Id)
                {
                    //valid
                    NewsCategory categoryDetails = await _db.NewsCategories.FindAsync(categoryId);
                    NewsCategory category = _mapper.Map<NewsCategoryDTO, NewsCategory>(newsCategoryDTO, categoryDetails);
                    var updateCategory = _db.NewsCategories.Update(category);

                    await _db.SaveChangesAsync();
                    return _mapper.Map<NewsCategory, NewsCategoryDTO>(updateCategory.Entity);
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
