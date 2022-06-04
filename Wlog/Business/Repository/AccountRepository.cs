using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<CustomUser> _userManager;

        public AccountRepository(AppDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<CustomUser> userManager)
        {
            _db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }
        public async Task<UserDTO> GetUser(string id)
        {
            try
            {
                //var user = _db.CustomUser.Find(id);
                UserDTO user = _mapper.Map<CustomUser, UserDTO>(
                    await _db.CustomUser.FirstOrDefaultAsync(x => x.Id == id));

                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<UserRoleDTO> GetUserRole(string id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id);
                var roles = await _userManager.GetRolesAsync(user);
                UserRoleDTO userRoleDTO = new UserRoleDTO();
                userRoleDTO.Name = roles.FirstOrDefault();

                return userRoleDTO;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<UserDTO> UpdateUser(UserDTO userDTO)
        {
            try
            {

                if (userDTO != null)
                {
                    CustomUser user = _db.CustomUser.Find(userDTO.Id);
                    CustomUser customUser = _mapper.Map<UserDTO, CustomUser>(userDTO, user);

                    var updateUser = _db.CustomUser.Update(customUser);

                    await _db.SaveChangesAsync();

                    return _mapper.Map<CustomUser, UserDTO>(updateUser.Entity);
                }
                else
                {
                    return null;
                }


            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
