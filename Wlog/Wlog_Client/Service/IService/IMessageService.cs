using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Client.Service.IService
{
    public interface IMessageService
    {
        public Task<MessageDTO> CreateMessage(MessageDTO messageDTO);
        public Task<IEnumerable<MessageDTO>> GetMessages();
    }
}
