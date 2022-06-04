using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IMessageRepository
    {
        public Task<MessageDTO> Create(MessageDTO messageDTO);
        public Task<IEnumerable<MessageDTO>> GetAll();
    }
}
