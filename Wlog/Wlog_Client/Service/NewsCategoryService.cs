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
    public class NewsCategoryService : INewsCategoryService
    {
        private readonly HttpClient _client;

        public NewsCategoryService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<NewsCategoryDTO>> GetAllCategory()
        {
            var response = await _client.GetAsync($"newscategory");
            var content = await response.Content.ReadAsStringAsync();
            var newscategory = JsonConvert.DeserializeObject<IEnumerable<NewsCategoryDTO>>(content);
            return newscategory;
        }

        public async Task<NewsCategoryDTO> GetCategory(int? cateId)
        {
            var response = await _client.GetAsync($"newscategory/{cateId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var news = JsonConvert.DeserializeObject<NewsCategoryDTO>(content);


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
