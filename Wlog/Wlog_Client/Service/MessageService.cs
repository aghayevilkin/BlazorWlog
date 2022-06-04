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
    public class MessageService : IMessageService
    {
        private readonly HttpClient _client;

        public MessageService(HttpClient client)
        {
            _client = client;
        }

        public async Task<MessageDTO> CreateMessage(MessageDTO messageDTO)
        {
            var content = JsonConvert.SerializeObject(messageDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/news/CreateMessage", bodyContent);
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<MessageDTO>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<MessageDTO>> GetMessages()
        {
            var response = await _client.GetAsync($"news/CreateMessage");
            var content = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<IEnumerable<MessageDTO>>(content);
            return model;
        }
    }
}
