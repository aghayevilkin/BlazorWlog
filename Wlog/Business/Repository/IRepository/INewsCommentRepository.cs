using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface INewsCommentRepository
    {
        public Task<NewsCommentDTO> CreateNewsComment(NewsCommentDTO newsCommentDTO);
        public Task<IEnumerable<NewsCommentDTO>> GetAllNewsComment();
        public Task<int> DeleteNewsComment(int categoryId);
    }
}
