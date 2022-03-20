using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface INewsImagesRepository
    {
        public Task<int> CreateNewsImage(NewsImageDTO image);
        public Task<int> DeleteNewsImageByImageId(int imageId);
        public Task<int> DeleteNewsImageByNewsId(int newsId);
        public Task<int> DeleteNewsImageByUrl(string imageUrl);
        public Task<IEnumerable<NewsImageDTO>> GetNewsImages(int newsId);
    }
}
