using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IAccountRepository
    {
        public Task<UserDTO> GetUser(string id);
        public Task<UserRoleDTO> GetUserRole(string id);
        public Task<UserDTO> UpdateUser(UserDTO userDTO);
    }
}
