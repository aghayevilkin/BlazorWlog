using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Client.Service.IService
{
    public interface INewsCommentService
    {
        public Task<NewsCommentDTO> CreateNewsComment(NewsCommentDTO newsCommentDTO);
        public Task<IEnumerable<NewsCommentDTO>> GetNewsComment();
    }
}
