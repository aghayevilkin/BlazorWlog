using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class SubscribeRepository : ISubscribeRepository
    {

        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public SubscribeRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<SubscribeDTO> CreateSubscribe(SubscribeDTO subscribeDTO)
        {
            Subscribe subscribe = _mapper.Map<SubscribeDTO, Subscribe>(subscribeDTO);
            subscribe.AddedDate = DateTime.Now;
            var addedSubscribe = await _db.Subscribes.AddAsync(subscribe);

            await _db.SaveChangesAsync();
            return _mapper.Map<Subscribe, SubscribeDTO>(addedSubscribe.Entity);
        }

        public async Task<IEnumerable<SubscribeDTO>> GetAllSubscribe()
        {
            try
            {
                IEnumerable<SubscribeDTO> subscribeDTOs =
                            _mapper.Map<IEnumerable<Subscribe>, IEnumerable<SubscribeDTO>>
                            (_db.Subscribes.OrderByDescending(x => x.AddedDate));

                return subscribeDTOs;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
