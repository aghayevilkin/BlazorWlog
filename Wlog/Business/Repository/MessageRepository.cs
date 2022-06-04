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
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public MessageRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<MessageDTO> Create(MessageDTO messageDTO)
        {
            Message message = _mapper.Map<MessageDTO, Message>(messageDTO);
            message.AddedDate = DateTime.Now;
            var addedModel = await _db.Messages.AddAsync(message);

            await _db.SaveChangesAsync();
            return _mapper.Map<Message, MessageDTO>(addedModel.Entity);
        }

        public async Task<IEnumerable<MessageDTO>> GetAll()
        {
            try
            {
                IEnumerable<MessageDTO> model =
                            _mapper.Map<IEnumerable<Message>, IEnumerable<MessageDTO>>
                            (_db.Messages.OrderByDescending(x => x.AddedDate));

                return model;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
