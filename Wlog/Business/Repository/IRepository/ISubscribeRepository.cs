using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ISubscribeRepository
    {
        public Task<SubscribeDTO> CreateSubscribe(SubscribeDTO subscribeDTO);
        public Task<IEnumerable<SubscribeDTO>> GetAllSubscribe();
    }
}
