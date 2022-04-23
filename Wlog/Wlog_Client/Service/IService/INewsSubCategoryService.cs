using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Client.Service.IService
{
    public interface INewsSubCategoryService
    {
        public Task<IEnumerable<NewsSubCategoryDTO>> GetNewsSubCategory();
    }
}
