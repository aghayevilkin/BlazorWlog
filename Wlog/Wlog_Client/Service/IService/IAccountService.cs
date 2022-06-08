using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Client.Service.IService
{
    public interface IAccountService
    {
        public Task<UserDTO> USerDetails(string id);
        public Task<UserRoleDTO> USerRole(string id);
        public Task<UserDTO> UpdateUser(UserDTO userDTO);
        public Task<AuthenticationResponseDTO> ChangePassword(ChangePasswordDTO changePasswordDTO);
    }
}
