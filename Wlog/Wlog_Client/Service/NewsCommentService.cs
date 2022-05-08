using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wlog_Client.Service.IService;

namespace Wlog_Client.Service
{
    public class NewsCommentService : INewsCommentService
    {
        private readonly HttpClient _client;

        public NewsCommentService(HttpClient client)
        {
            _client = client;
        }

        public async Task<NewsCommentDTO> CreateNewsComment(NewsCommentDTO newsCommentDTO)
        {
            var content = JsonConvert.SerializeObject(newsCommentDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/newscomment", bodyContent);
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<NewsCommentDTO>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<NewsCommentDTO>> GetNewsComment()
        {
            var response = await _client.GetAsync($"newscomment");
            var content = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<IEnumerable<NewsCommentDTO>>(content);
            return model;
        }
    }
}
