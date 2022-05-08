using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.AspNetCore.Http;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class NewsCommentRepository : INewsCommentRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public NewsCommentRepository(AppDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<NewsCommentDTO> CreateNewsComment(NewsCommentDTO newsCommentDTO)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            NewsComment newsComment = _mapper.Map<NewsCommentDTO, NewsComment>(newsCommentDTO);
            newsComment.AddedDate = DateTime.Now;

            if (newsCommentDTO.UserId == null)
            {
                newsCommentDTO.UserId = userId;
            }

            var addedComment = await _db.NewsComments.AddAsync(newsComment);

            await _db.SaveChangesAsync();
            return _mapper.Map<NewsComment, NewsCommentDTO>(addedComment.Entity);
        }

        public Task<int> DeleteNewsComment(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NewsCommentDTO>> GetAllNewsComment()
        {
            try
            {
                IEnumerable<NewsCommentDTO> newsCommentDTOs =
                            _mapper.Map<IEnumerable<NewsComment>, IEnumerable<NewsCommentDTO>>
                            (_db.NewsComments.OrderByDescending(x => x.AddedDate));

                return newsCommentDTOs;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
