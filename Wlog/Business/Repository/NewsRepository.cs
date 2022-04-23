using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class NewsRepository : INewsRepository
    {

        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public NewsRepository(AppDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<NewsDTO> CreateNews(NewsDTO newsDTO)
        {

            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            News news = _mapper.Map<NewsDTO, News>(newsDTO);
            news.AddedDate = DateTime.Now;
            news.UserId = userId;
            news.NewsStatus = NewsStatus.Active;
            var addedNews = await _db.News.AddAsync(news);

            await _db.SaveChangesAsync();
            return _mapper.Map<News, NewsDTO>(addedNews.Entity);
        }

        public async Task<int> DeleteNews(int newsId)
        {
            var newsDetails = await _db.News.FindAsync(newsId);
            if (newsDetails != null)
            {

                var allimages = await _db.NewsImages.Where(x => x.NewsId == newsId).ToListAsync();

                _db.NewsImages.RemoveRange(allimages);
                _db.News.Remove(newsDetails);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<NewsDTO>> GetAllNews()
        {
            try
            {
                IEnumerable<NewsDTO> newsDTOs =
                            _mapper.Map<IEnumerable<News>, IEnumerable<NewsDTO>>
                            (_db.News.Include(x => x.NewsImages).Include(c=>c.Category).ThenInclude(s=>s.NewsCategory).OrderByDescending(x => x.AddedDate));

                return newsDTOs;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<NewsDTO> GetNews(int newsId)
        {
            try
            {
                NewsDTO news = _mapper.Map<News, NewsDTO>(
                    await _db.News.Include(x => x.NewsImages).Include(c => c.Category).ThenInclude(s => s.NewsCategory).FirstOrDefaultAsync(x => x.Id == newsId));

                return news;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<NewsDTO> IsNewsUnique(string name, int newsId = 0)
        {
            try
            {
                if (newsId == 0)
                {
                    NewsDTO news = _mapper.Map<News, NewsDTO>(
                    await _db.News.FirstOrDefaultAsync(x => x.Title.ToLower() == name.ToLower()));

                    return news;
                }
                else
                {
                    NewsDTO news = _mapper.Map<News, NewsDTO>(
                    await _db.News.FirstOrDefaultAsync(x => x.Title.ToLower() == name.ToLower()
                    && x.Id != newsId));

                    return news;
                }

            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<NewsDTO> UpdateNews(int newsId, NewsDTO newsDTO)
        {
            try
            {
                if (newsId == newsDTO.Id)
                {
                    //valid
                    News newsDetails = await _db.News.FindAsync(newsId);
                    News news = _mapper.Map<NewsDTO, News>(newsDTO, newsDetails);
                    var updateNews = _db.News.Update(news);

                    await _db.SaveChangesAsync();
                    return _mapper.Map<News, NewsDTO>(updateNews.Entity);
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
