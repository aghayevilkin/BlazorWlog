using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface INewsRepository
    {
        public Task<NewsDTO> CreateNews(NewsDTO newsDTO);
        public Task<NewsDTO> UpdateNews(int newsId, NewsDTO newsDTO);
        public Task<NewsDTO> GetNews(int newsId);
        public Task<int> DeleteNews(int newsId);
        public Task<IEnumerable<NewsDTO>> GetAllNews();
        public Task<NewsDTO> IsNewsUnique(string name, int newsId = 0);

        public Task<NewsPaginationDTO> GetNewsPagingList(int currentPage = 1, int pageSize = 10);
    }
}
