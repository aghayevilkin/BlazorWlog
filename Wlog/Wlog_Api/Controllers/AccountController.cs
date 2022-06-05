using Business.Repository.IRepository;
using Common;
using DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Wlog_Api.Helper;

namespace Wlog_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<CustomUser> _signInManager;
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly APISettings _aPISettings;
        private readonly IAccountRepository _accountRepository;

        public AccountController(SignInManager<CustomUser> signInManager, UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<APISettings> options, IAccountRepository accountRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _aPISettings = options.Value;
            _accountRepository = accountRepository;
        }



        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp([FromBody] UserRequestDTO userRequestDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new RegistrationResponseDTO
                {
                    Errors = ModelState.Values
                        .SelectMany(m => m.Errors)
                        .Select(e => e.ErrorMessage)
                });
            }

            var user = new CustomUser
            {
                UserName = userRequestDTO.Email,
                Email = userRequestDTO.Email,
                Name = userRequestDTO.Name,
                Surname = userRequestDTO.Surname,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, userRequestDTO.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new RegistrationResponseDTO { Errors = errors, IsRegisterationSuccessful = false });

            }

            var roleResult = await _userManager.AddToRoleAsync(user, SD.Role_Customer);

            if (!roleResult.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new RegistrationResponseDTO { Errors = errors, IsRegisterationSuccessful = false });
            }

            return StatusCode(201);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn([FromBody] AuthenticationDTO authenticationDTO)
        {
            var result = await _signInManager.PasswordSignInAsync(authenticationDTO.UserName,
                authenticationDTO.Password, false, false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(authenticationDTO.UserName);
                if (user == null)
                {
                    return Unauthorized(new AuthenticationResponseDTO
                    {
                        IsAuthSuccessful = false,
                        ErrorMessage = "Invalid Authentication"
                    });
                }

                //everything is valid and we need to login the user

                var signinCredentials = GetSigningCredentials();
                var claims = await GetClaims(user);

                var TokenOptions = new JwtSecurityToken(
                    issuer: _aPISettings.ValidIssuer,
                    audience: _aPISettings.ValidAudience,
                    claims: claims,
                    expires: DateTime.Now.AddDays(30),
                    signingCredentials: signinCredentials);

                var token = new JwtSecurityTokenHandler().WriteToken(TokenOptions);
                //var roles = await _userManager.GetRolesAsync(user);



                return Ok(new AuthenticationResponseDTO
                {
                    IsAuthSuccessful = true,
                    Token = token,
                    userDTO = new UserDTO
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Surname = user.Surname,
                        Profision = user.Profision,
                        Adress = user.Adress,
                        IsVerify = user.IsVerify,
                        About = user.About,
                        Email = user.Email,
                        PhoneNo = user.PhoneNumber
                        //Role = roles.FirstOrDefault()
                    }
                });;

            }
            else
            {
                return Unauthorized(new AuthenticationResponseDTO
                {
                    IsAuthSuccessful = false,
                    ErrorMessage = "Invalid Authentication"
                });
            }
        }



        private SigningCredentials GetSigningCredentials()
        {
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_aPISettings.SecretKey));
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims(CustomUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Email),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim("Id",user.Id),
            };

            var roles = await _userManager.GetRolesAsync(await _userManager.FindByEmailAsync(user.Email));

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }





        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(string userId)
        {
            if (userId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid User Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var UserInfo = await _accountRepository.GetUser(userId);


            if (UserInfo == null)
            {
                return NotFound(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid User id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(UserInfo);

        }



        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserRole(string userId)
        {
            if (userId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid User Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var UserRoleInfo = await _accountRepository.GetUserRole(userId);



            if (UserRoleInfo == null)
            {
                return NotFound(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid User id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(UserRoleInfo);

        }



        [HttpPost]
        public async Task<IActionResult> UpdateUser([FromBody] UserDTO userDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountRepository.UpdateUser(userDTO);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while Updating User"
                });
            }
        }


    }
}
