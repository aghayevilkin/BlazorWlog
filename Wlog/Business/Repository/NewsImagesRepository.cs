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
    public class NewsImagesRepository : INewsImagesRepository
    {

        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public NewsImagesRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<int> CreateNewsImage(NewsImageDTO imageDTO)
        {
            var image = _mapper.Map<NewsImageDTO, NewsImage>(imageDTO);
            await _db.NewsImages.AddAsync(image);

            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteNewsImageByImageId(int imageId)
        {
            var image = await _db.NewsImages.FindAsync(imageId);
            _db.NewsImages.Remove(image);

            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteNewsImageByNewsId(int newsId)
        {
            var imageList = await _db.NewsImages.Where(x => x.NewsId == newsId).ToListAsync();
            _db.NewsImages.RemoveRange(imageList);

            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteNewsImageByUrl(string imageUrl)
        {
            var allImages = await _db.NewsImages.FirstOrDefaultAsync(x => x.NewsImageUrl.ToLower() == imageUrl.ToLower());
            if (allImages == null)
            {
                return 0;
            }
            _db.NewsImages.Remove(allImages);

            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<NewsImageDTO>> GetNewsImages(int newsId)
        {
            return _mapper.Map<IEnumerable<NewsImage>, IEnumerable<NewsImageDTO>>(
            await _db.NewsImages.Where(x => x.NewsId == newsId).ToListAsync());
        }
    }
}
