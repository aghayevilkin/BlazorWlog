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
    public class SubscribeService : ISubscribeService
    {

        private readonly HttpClient _client;

        public SubscribeService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<SubscribeDTO>> GetSubscribes()
        {
            var response = await _client.GetAsync($"subscribe");
            var content = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<IEnumerable<SubscribeDTO>>(content);
            return model;
        }

        public async Task<SubscribeDTO> CreateSubcribe(SubscribeDTO subscribeDTO)
        {
            var content = JsonConvert.SerializeObject(subscribeDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/subscribe", bodyContent);
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SubscribeDTO>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }
    }
}
