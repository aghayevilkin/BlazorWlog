using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Wlog_Client.Service.IService;

namespace Wlog_Client.Service
{
    public class NewsService : INewsService
    {
        private readonly HttpClient _client;

        public NewsService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<NewsDTO>> GetNews()
        {
            var response = await _client.GetAsync($"news");
            var content = await response.Content.ReadAsStringAsync();
            var news = JsonConvert.DeserializeObject<IEnumerable<NewsDTO>>(content);
            return news;
        }




        public async Task<NewsDTO> GetNewsDetails(int? newsId)
        {
            var response = await _client.GetAsync($"news/{newsId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var news = JsonConvert.DeserializeObject<NewsDTO>(content);


                return news;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<NewsPaginationDTO> GetNewsPaginationList(int currentPage = 1, int pageSize = 10)
        {
            var response = await _client.GetAsync($"news/getnewspaginglist?currentPage={currentPage}&pageSize={pageSize}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var news = JsonConvert.DeserializeObject<NewsPaginationDTO>(content);


                return news;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }

        }
    }
}
