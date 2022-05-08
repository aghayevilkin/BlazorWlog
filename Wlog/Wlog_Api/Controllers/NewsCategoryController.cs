using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsCategoryController : Controller
    {
        private readonly INewsCategoryRepository _newsCategoryRepository;
        private readonly INewsSubCategoryRepository _newsSubCategoryRepository;


        public NewsCategoryController(INewsCategoryRepository newsCategoryRepository, INewsSubCategoryRepository newsSubCategoryRepository)
        {
            _newsCategoryRepository = newsCategoryRepository;
            _newsSubCategoryRepository = newsSubCategoryRepository;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllSCategory()
        {

            var model = await _newsCategoryRepository.GetAllNewsCategory();
            return Ok(model);
        }



        [HttpGet("{cateId}")]
        public async Task<IActionResult> GetCategory(int? cateId)
        {
            if (cateId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid News Category Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var newsDetails = await _newsCategoryRepository.GetNewsCategory(cateId.Value);

            if (newsDetails == null)
            {
                return NotFound(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid News Category Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(newsDetails);

        }


    }
}
