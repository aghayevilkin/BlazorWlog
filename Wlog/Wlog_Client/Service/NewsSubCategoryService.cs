using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Wlog_Client.Service.IService;

namespace Wlog_Client.Service
{
    public class NewsSubCategoryService : INewsSubCategoryService
    {
        private readonly HttpClient _client;

        public NewsSubCategoryService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<NewsSubCategoryDTO>> GetNewsSubCategory()
        {
            var response = await _client.GetAsync($"news/NewsSubCategory");
            var content = await response.Content.ReadAsStringAsync();
            var newssubcategory = JsonConvert.DeserializeObject<IEnumerable<NewsSubCategoryDTO>>(content);
            return newssubcategory;
        }
    }
}
