using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Client.Service.IService
{
    public interface ISubscribeService
    {
        public Task<SubscribeDTO> CreateSubcribe(SubscribeDTO subscribeDTO);
        public Task<IEnumerable<SubscribeDTO>> GetSubscribes();
    }
}
