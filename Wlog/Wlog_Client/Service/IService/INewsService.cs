using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Client.Service.IService
{
    public interface INewsService
    {
        public Task<IEnumerable<NewsDTO>> GetNews();
        public Task<NewsDTO> GetNewsDetails(int? newsId);
        public Task<NewsPaginationDTO> GetNewsPaginationList(int currentPage = 1, int pageSize = 10);
        public Task<SavedNewsDTO> AddToSavedNews(SavedNewsDTO savedNewsDTO);
    }
}
